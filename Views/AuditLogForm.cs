using System;
using System.Windows.Forms;
using MuseumCatalog.Data;
using MuseumCatalog.Models;
using MuseumCatalog.Services;
using Utils;

namespace MuseumCatalog.Views
{
    public partial class AuditLogForm : Form
    {
        private readonly string _dbPath;
        private readonly AuditRepository _auditRepo;
        private readonly DatabaseChangeNotifier _notifier;

        public AuditLogForm(string dbPath)
        {
            InitializeComponent();

            _dbPath = dbPath;
            _auditRepo = new AuditRepository(dbPath);
            _notifier = new DatabaseChangeNotifier(dbPath);
            _notifier.DataChanged += OnDatabaseChanged;
            _notifier.Start();

            // По умолчанию — логи за текущие сутки
            dtpFilterFrom.Value = DateTime.Today;
            dtpFilterTo.Value = DateTime.Today.AddDays(1).AddSeconds(-1);

            LoadAudit();
        }

        private void LoadAudit()
        {
            try
            {
                string pc = txtFilterPC.Text.Trim();
                string op = txtFilterOp.Text.Trim();
                DateTime? dateFrom = dtpFilterFrom.Checked ? dtpFilterFrom.Value : null;
                DateTime? dateTo = dtpFilterTo.Checked ? dtpFilterTo.Value : null;

                dgAudit.DataSource = _auditRepo.GetFiltered(pc, op, dateFrom, dateTo);
            }
            catch
            {
                /* БД заблокирована — оставляем текущие данные */
            }
        }

        private void OnDatabaseChanged(object sender, EventArgs e)
        {
            if (_notifier is { Paused: true })
                return;
            LoadAudit();
        }

        private void BtnApply_Click(object sender, EventArgs e) => LoadAudit();

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtFilterPC.Clear();
            txtFilterOp.Text = "";
            dtpFilterFrom.Value = DateTime.Today;
            dtpFilterTo.Value = DateTime.Today.AddDays(1).AddSeconds(-1);
            dtpFilterFrom.Checked = true;
            dtpFilterTo.Checked = true;
            LoadAudit();
        }

        // ─── Просмотр карточки из лога ───

        private void BtnViewCard_Click(object sender, EventArgs e)
        {
            if (dgAudit.CurrentRow?.DataBoundItem is not AuditLog log)
                return;

            if (!log.HasSnapshot)
            {
                MessageBox.Show("В этой записи нет снимка данных экспоната.",
                    "Просмотр", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _notifier.MarkPaused();
            try
            {
                // Открываем в режиме только чтения
                using ExhibitEditorForm viewer = new(_dbPath, log.ToExhibit(), readOnly: true);
                viewer.ShowDialog();
            }
            finally
            {
                _notifier.Unpause();
            }
        }

        // ─── Восстановление данных из лога ───

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            if (dgAudit.CurrentRow?.DataBoundItem is not AuditLog log)
                return;

            if (!log.HasSnapshot)
            {
                MessageBox.Show("В этой записи нет снимка данных для восстановления.",
                    "Восстановление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(
                "Восстановить данные экспоната из этой записи журнала?\n" +
                "Текущие данные карточки будут перезаписаны.",
                "Восстановление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                is not DialogResult.Yes)
                return;

            _notifier.MarkPaused();
            try
            {
                // Проверяем, существует ли ещё экспонат
                ExhibitRepository repo = new(_dbPath);
                Exhibit existing = repo.GetById(log.ExhibitID);

                if (existing is not null)
                {
                    // Восстанавливаем в существующую карточку (без перезаписи фото)
                    existing.Cipher = log.Cipher ?? "";
                    existing.KPNumber = log.KPNumber ?? "";
                    existing.TimeStamp = log.TimeStamp;
                    existing.Source = log.Source ?? "";
                    existing.ActNumber = log.ActNumber ?? "";
                    existing.MaterialTechnique = log.MaterialTechnique ?? "";
                    existing.ItemName = log.ItemName ?? "";
                    existing.Description = log.Description ?? "";
                    existing.Size = log.Size ?? "";
                    existing.Condition = log.Condition ?? "";
                    existing.StoragePlaceID = log.StoragePlaceID;
                    // Фото не трогаем — оставляем текущее

                    repo.Update(existing);
                    _auditRepo.Log("RESTORE_EXHIBIT", Environment.MachineName, log.ExhibitID);

                    MessageBox.Show("Данные восстановлены.", "Готово",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Экспонат удалён — создаём новый из снимка
                    Exhibit restored = log.ToExhibit();
                    restored.ID = 0; // Новый экспонат
                    int newId = repo.Insert(restored);
                    _auditRepo.Log("RESTORE_EXHIBIT_NEW", Environment.MachineName, newId);

                    MessageBox.Show(
                        "Экспонат был удалён. Создана новая карточка №" + newId + ".",
                        "Восстановление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка восстановления: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _notifier.Unpause();
            }
        }

        private void BtnClearLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Удалить ВСЕ записи журнала? Это действие необратимо.",
                "Очистка журнала",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) is not DialogResult.Yes)
                return;

            _notifier.MarkPaused();
            try
            {
                _auditRepo.ClearAll();
                LoadAudit();
                MessageBox.Show("Журнал очищен.", "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось очистить журнал: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _notifier.Unpause();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _notifier?.Stop();
            _notifier?.Dispose();
            base.OnFormClosed(e);
        }

        private void dgAudit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnViewCard_Click(null, null);
        }

        private void AuditLogForm_Load(object sender, EventArgs e) => this.LoadFormPosition(true);

        private void AuditLogForm_FormClosing(object sender, FormClosingEventArgs e) => this.SaveFormPosition();
    }
}
