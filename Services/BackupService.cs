using System;
using System.IO;
using System.Linq;

namespace MuseumCatalog.Services
{
    public static class BackupService
    {
        public static string CreateBackup(string dbPath)
        {
            if (!File.Exists(dbPath)) return null;

            string dir = Path.GetDirectoryName(dbPath);
            string name = Path.GetFileNameWithoutExtension(dbPath);
            string ext = Path.GetExtension(dbPath);
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string backupPath = Path.Combine(dir, name + "_backup_" + timestamp + ext);

            File.Copy(dbPath, backupPath, overwrite: true);

            var backups = Directory.GetFiles(dir, name + "_backup_*" + ext)
                .OrderBy(f => f)
                .ToList();
            while (backups.Count > 10)
            {
                File.Delete(backups[0]);
                backups.RemoveAt(0);
            }

            return backupPath;
        }
    }
}
