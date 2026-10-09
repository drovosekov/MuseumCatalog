using System;
using System.Data.SQLite;

namespace MuseumCatalog.Data
{
    public class LockRepository
    {
        private readonly string _connectionString;

        public LockRepository(string dbPath)
        {
            _connectionString = DatabaseService.GetConnectionString(dbPath);
        }

        public string TryLock(int exhibitId, string pcIdentifier)
        {
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();

            using var check = new SQLiteCommand(
                "SELECT PCIdentifier FROM tbl_Locks WHERE ExhibitID = @id", conn);
            check.Parameters.AddWithValue("@id", exhibitId);
            var existing = check.ExecuteScalar();

            if (existing != null)
                return existing.ToString();

            using var lockCmd = new SQLiteCommand(
                "INSERT INTO tbl_Locks (ExhibitID, PCIdentifier, LockTime) VALUES (@id, @pc, @time)", conn);
            lockCmd.Parameters.AddWithValue("@id", exhibitId);
            lockCmd.Parameters.AddWithValue("@pc", pcIdentifier);
            lockCmd.Parameters.AddWithValue("@time", DateTime.Now);
            lockCmd.ExecuteNonQuery();

            return null;
        }

        public void Unlock(int exhibitId, string pcIdentifier)
        {
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand(
                "DELETE FROM tbl_Locks WHERE ExhibitID = @id AND PCIdentifier = @pc", conn);
            cmd.Parameters.AddWithValue("@id", exhibitId);
            cmd.Parameters.AddWithValue("@pc", pcIdentifier);
            cmd.ExecuteNonQuery();
        }

        public void CleanupStaleLocks(TimeSpan maxAge)
        {
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand(
                "DELETE FROM tbl_Locks WHERE LockTime < @cutoff", conn);
            cmd.Parameters.AddWithValue("@cutoff", DateTime.Now - maxAge);
            cmd.ExecuteNonQuery();
        }
    }
}
