using MuseumCatalog.Data;
using MuseumCatalog.Models;
using MuseumCatalog.Services;
using System;
using System.Windows.Forms;

namespace MuseumCatalog.Views
{
    public partial class OptionsForm : Form
    {
        private readonly AppConfig _config;
        private readonly string _pcId;
        private readonly StoragePlaceRepository _placeRepo;

        public OptionsForm()
        {
            InitializeComponent();
        }
        public OptionsForm(AppConfig config, string pcId)
        {
            InitializeComponent();

            _config = config;
            _pcId = pcId;
            _placeRepo = new StoragePlaceRepository(config.DatabasePath);

            txtMuseumName.Text = _config.MuseumName;
            txtDbPath.Text = _config.DatabasePath;
            txtTemplatePath.Text = _config.TemplatePath;
            txtPCId.Text = pcId;

            LoadPlaces();
        }
        // ─── Настройки ───

        private void BtnBrowseDb_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog { Filter = "SQLite БД (*.db;*.sqlite)|*.db;*.sqlite|Все файлы|*.*" };
            if (ofd.ShowDialog() == DialogResult.OK)
                txtDbPath.Text = ofd.FileName;
        }

        private void BtnBrowseTemplate_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog { Filter = "Word шаблон (*.docx)|*.docx|RTF (*.rtf)|*.rtf" };
            if (ofd.ShowDialog() == DialogResult.OK)
                txtTemplatePath.Text = ofd.FileName;
        }

        private void BtnCreateDb_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog { Filter = "SQLite БД (*.db)|*.db", FileName = "museum.db" };
            if (sfd.ShowDialog() is not DialogResult.OK)
                return;

            try
            {
                DatabaseService.InitializeDatabase(sfd.FileName);
                txtDbPath.Text = sfd.FileName;
                MessageBox.Show("БД создана успешно.", "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            _config.MuseumName = txtMuseumName.Text;
            _config.DatabasePath = txtDbPath.Text;
            _config.TemplatePath = txtTemplatePath.Text;
            _config.PCIdentifier = _pcId;
            ConfigService.Save(_config);
            MessageBox.Show("Настройки сохранены.", "Готово",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
        // ─── Места хранения ───

        private void BtnAddPlace_Click(object sender, EventArgs e)
        {
            using var dlg = new InputDialogForm("Новое место хранения", "Введите название:");
            if (dlg.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dlg.ResultText))
            {
                try { _placeRepo.Add(dlg.ResultText); }
                catch { MessageBox.Show("Такое место уже существует.", "Ошибка"); }
                LoadPlaces();
            }
        }

        private void BtnEditPlace_Click(object sender, EventArgs e)
        {
            if (dgPlaces.CurrentRow?.DataBoundItem is not StoragePlace selected)
                return;

            using var dlg = new InputDialogForm("Изменение места хранения", "Введите название:", selected.PlaceName);
            if (dlg.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dlg.ResultText))
            {
                try { _placeRepo.Update(selected.ID, dlg.ResultText); }
                catch { MessageBox.Show("Такое место уже существует.", "Ошибка"); }
                LoadPlaces();
            }
        }

        private void LoadPlaces()
        {
            try
            {
                dgPlaces.DataSource = _placeRepo.GetAll();
            }
            catch { }
        }

        private void BtnDeletePlace_Click(object sender, EventArgs e)
        {
            if (dgPlaces.CurrentRow?.DataBoundItem is not StoragePlace selected)
                return;

            if (MessageBox.Show($"Удалить \"{selected.PlaceName}\"?", "Подтверждение",
                MessageBoxButtons.YesNo) is not DialogResult.Yes)
                return;

            try { _placeRepo.Delete(selected.ID); }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadPlaces();
        }

        // ─── Журнал работы ───

        private void BtnViewAudit_Click(object sender, EventArgs e)
        {
            using AuditLogForm auditForm = new(_config.DatabasePath);
            auditForm.ShowDialog();
        }

    }
}
