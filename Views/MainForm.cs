using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MuseumCatalog.Data;
using MuseumCatalog.Models;
using MuseumCatalog.Services;
using Utils;

namespace MuseumCatalog.Views
{
    public partial class MainForm : Form
    {
        private readonly AppConfig _config;
        private readonly string _pcId;
        private ExhibitRepository _exhibitRepo;
        private StoragePlaceRepository _placeRepo;
        private AuditRepository _auditRepo;
        private LockService _lockService;
        private readonly DatabaseChangeNotifier _notifier;

        // Конструктор без параметров — для дизайнера
        public MainForm() { InitializeComponent(); }

        public MainForm(AppConfig config, string pcId) : this()
        {
            _config = config;
            _pcId = pcId;

            // Автообновление при изменении БД другим процессом
            _notifier = new DatabaseChangeNotifier(config.DatabasePath);
            _notifier.DataChanged += OnDatabaseChanged;
            _notifier.Start();

            Inti(config);
        }

        private void Inti(AppConfig config)
        {
            _exhibitRepo = new ExhibitRepository(config.DatabasePath);
            _placeRepo = new StoragePlaceRepository(config.DatabasePath);
            _auditRepo = new AuditRepository(config.DatabasePath);
            _lockService = new LockService(config.DatabasePath);

            LoadExhibits();
            LoadPlacesFilter();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _notifier?.Stop();
            _notifier?.Dispose();
            base.OnFormClosed(e);
        }

        // ─── Автообновление ───

        private void OnDatabaseChanged(object sender, EventArgs e)
        {
            if (_notifier is { Paused: true })
                return;

            LoadExhibitsPreserveSelection();
            LoadPlacesFilter();
        }

        // ─── Загрузка данных (с защитой от очистки при ошибке) ───

        private void LoadExhibits()
        {
            try
            {
                dgExhibits.DataSource = _exhibitRepo.GetAll();
            }
            catch { /* БД заблокирована — оставляем текущие данные */ }
        }


        private void LoadPlacesFilter()
        {
            try
            {
                var places = _placeRepo.GetAll();
                cbFilterPlace.DisplayMember = "PlaceName";
                cbFilterPlace.ValueMember = "ID";
                cbFilterPlace.DataSource = places;
                cbFilterPlace.SelectedIndex = -1;
            }
            catch { }
        }

        // ─── Загрузка с сохранением выделения ───

        private void LoadExhibitsPreserveSelection()
        {
            int selectedId = -1;
            if (dgExhibits.CurrentRow?.DataBoundItem is Exhibit ex)
                selectedId = ex.ID;

            LoadExhibits();

            if (selectedId < 0) return;
            foreach (DataGridViewRow row in dgExhibits.Rows)
            {
                if (row.DataBoundItem is Exhibit item && item.ID == selectedId)
                {
                    dgExhibits.CurrentCell = row.Cells[1];
                    break;
                }
            }
        }

        // ─── Фильтры ───

        private void BtnApplyFilter_Click(object sender, EventArgs e)
        {
            int? placeId = cbFilterPlace.SelectedValue switch
            {
                int v => v,
                _ => null
            };

            DateTime? dateFrom = dtpFilterFrom.Checked ? dtpFilterFrom.Value : null;
            DateTime? dateTo = dtpFilterTo.Checked ? dtpFilterTo.Value : null;

            try
            {
                dgExhibits.DataSource = _exhibitRepo.GetAll(
                    txtFilterCipher.Text, txtFilterKP.Text, txtFilterAct.Text,
                    txtFilterName.Text, txtFilterDesc.Text,
                    dateFrom, dateTo, placeId);
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить данные. БД может быть заблокирована.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClearFilter_Click(object sender, EventArgs e)
        {
            txtFilterCipher.Clear();
            txtFilterKP.Clear();
            txtFilterAct.Clear();
            txtFilterName.Clear();
            txtFilterDesc.Clear();
            dtpFilterFrom.Checked = false;
            dtpFilterTo.Checked = false;
            cbFilterPlace.SelectedIndex = -1;
            LoadExhibits();
        }

        // ─── Экспонаты: CRUD ───

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _notifier?.MarkPaused();
            using var editor = new ExhibitEditorForm(_config.DatabasePath, null);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                _auditRepo.Log("ADD_EXHIBIT", _pcId, editor.ResultExhibit.ID);
            }
            _notifier?.Unpause();
            LoadExhibitsPreserveSelection();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgExhibits.CurrentRow.DataBoundItem is not Exhibit selected)
                return;

            string lockHolder = _lockService.TryLock(selected.ID, _pcId);
            if (lockHolder is not null)
            {
                MessageBox.Show("Карточка заблокирована пользователем:\n" + lockHolder,
                    "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Сохраняем снимок состояния ДО изменения
            Exhibit snapshot = _exhibitRepo.GetById(selected.ID);

            _notifier?.MarkPaused();
            try
            {
                using ExhibitEditorForm editor = new(_config.DatabasePath, selected);
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    // Логируем со снимком состояния до изменения
                    if (snapshot is not null)
                        _auditRepo.LogWithSnapshot("EDIT_EXHIBIT", _pcId, snapshot);
                    else
                        _auditRepo.Log("EDIT_EXHIBIT", _pcId, editor.ResultExhibit.ID);
                }
            }
            finally
            {
                _lockService.Unlock(selected.ID, _pcId);
                _notifier?.Unpause();
            }
            LoadExhibitsPreserveSelection();
        }

        private void DgExhibits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            BtnEdit_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgExhibits.CurrentRow?.DataBoundItem is not Exhibit selected)
                return;

            if (MessageBox.Show($"Удалить карточку №{selected.ID}?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) is not DialogResult.Yes)
                return;

            // Сохраняем снимок состояния ДО удаления
            var snapshot = _exhibitRepo.GetById(selected.ID);

            try
            {
                _exhibitRepo.Delete(selected.ID);
                if (snapshot is not null)
                    _auditRepo.LogWithSnapshot("DELETE_EXHIBIT", _pcId, snapshot);
                else
                    _auditRepo.Log("DELETE_EXHIBIT", _pcId, selected.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadExhibitsPreserveSelection();
        }

        // ─── Печать ───

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (dgExhibits.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите карточки для печати.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(_config.TemplatePath) || !File.Exists(_config.TemplatePath))
            {
                MessageBox.Show("Укажите путь к шаблону в настройках.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var config = ConfigService.Load();
                if (dgExhibits.CurrentRow?.DataBoundItem is not Exhibit exhibit)
                    return;

                string outputDir = Path.GetDirectoryName(config.DatabasePath);
                string resultPath = TemplatePrintService.GenerateDocument(exhibit, config.MuseumName, config.TemplatePath, outputDir);

                MessageBox.Show("Документ создан:\n" + resultPath, "Печать",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка печати: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            using OptionsForm opt = new(_config, _pcId);
            opt.ShowDialog();

            Inti(_config);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using AboutForm af = new();
            af.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LoadFormPosition(true);
            if (!string.IsNullOrEmpty(_config.MuseumName))
                this.Text += " - " + _config.MuseumName;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => this.SaveFormPosition();
    }
}