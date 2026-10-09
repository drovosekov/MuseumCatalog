using System;
using System.Windows.Forms;
using MuseumCatalog.Services;
using MuseumCatalog.Views;

namespace MuseumCatalog
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                var config = ConfigService.Load();

                if (string.IsNullOrEmpty(config.DatabasePath))
                {
                    string pcId = PCIdentifierService.Generate();
                    using var settings = new SettingsForm(config, pcId);
                    if (settings.ShowDialog() != DialogResult.OK)
                        return;
                    config = ConfigService.Load();
                }

                try
                {
                    Data.DatabaseService.InitializeDatabase(config.DatabasePath);
                    BackupService.CreateBackup(config.DatabasePath);

                    string pcId = PCIdentifierService.Generate();
                    var lockSvc = new LockService(config.DatabasePath);
                    lockSvc.CleanupStaleLocks(TimeSpan.FromHours(1));

                    var auditRepo = new Data.AuditRepository(config.DatabasePath);
                    auditRepo.Log("OPEN_DB", pcId, 0);

                    Application.Run(new MainForm(config, pcId));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Ошибка инициализации:\n" + ex.Message + "\n\n" + (ex.InnerException?.Message ?? ""),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка загрузки:\n" + ex.Message,
                    "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
