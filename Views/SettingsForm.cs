using System.Windows.Forms;
using MuseumCatalog.Data;
using MuseumCatalog.Services;

namespace MuseumCatalog.Views
{
    public partial class SettingsForm : Form
    {
        private readonly AppConfig _config;
        private readonly string _pcId;

        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(AppConfig config, string pcId) : this()
        {
            _config = config;
            _pcId = pcId;

            txtMuseumName.Text = config.MuseumName;
            txtDbPath.Text = config.DatabasePath;
            txtTemplatePath.Text = config.TemplatePath;
            txtPCId.Text = pcId;
        }

        private void BtnBrowseDb_Click(object sender, System.EventArgs e)
        {
            using OpenFileDialog ofd = new() { Filter = "SQLite БД (*.db;*.sqlite)|*.db;*.sqlite|Все файлы|*.*" };
            if (ofd.ShowDialog() == DialogResult.OK)
                txtDbPath.Text = ofd.FileName;
        }

        private void BtnCreateDb_Click(object sender, System.EventArgs e)
        {
            using SaveFileDialog sfd = new () { Filter = "SQLite БД (*.db)|*.db", FileName = "museum.db" };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            DatabaseService.InitializeDatabase(sfd.FileName);
            txtDbPath.Text = sfd.FileName;
            MessageBox.Show("БД создана.", "Готово");
        }

        private void BtnBrowseTemplate_Click(object sender, System.EventArgs e)
        {
            using OpenFileDialog ofd = new () { Filter = "Word шаблон (*.docx)|*.docx" };
            if (ofd.ShowDialog() == DialogResult.OK)
                txtTemplatePath.Text = ofd.FileName;
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            _config.MuseumName = txtMuseumName.Text;
            _config.DatabasePath = txtDbPath.Text;
            _config.TemplatePath = txtTemplatePath.Text;
            _config.PCIdentifier = _pcId;
            ConfigService.Save(_config);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
