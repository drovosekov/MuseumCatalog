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
            using SQLiteConnection conn = new(_connectionString);
            conn.Open();

            using SQLiteCommand check = new(
                "SELECT PCIdentifier FROM Locks WHERE ExhibitID = @id", conn);
            check.Parameters.AddWithValue("@id", exhibitId);
            var existing = check.ExecuteScalar();

            if (existing != null)
                return existing.ToString();

            using SQLiteCommand lockCmd = new(
                "INSERT INTO Locks (ExhibitID, PCIdentifier, LockTime) VALUES (@id, @pc, @time)", conn);
            lockCmd.Parameters.AddWithValue("@id", exhibitId);
            lockCmd.Parameters.AddWithValue("@pc", pcIdentifier);
            lockCmd.Parameters.AddWithValue("@time", DateTime.Now);
            lockCmd.ExecuteNonQuery();

            return null;
        }

        public void Unlock(int exhibitId, string pcIdentifier)
        {
            using SQLiteConnection conn = new(_connectionString);
            conn.Open();
            using SQLiteCommand cmd = new(
                "DELETE FROM Locks WHERE ExhibitID = @id AND PCIdentifier = @pc", conn);
            cmd.Parameters.AddWithValue("@id", exhibitId);
            cmd.Parameters.AddWithValue("@pc", pcIdentifier);
            cmd.ExecuteNonQuery();
        }

        public void CleanupStaleLocks(TimeSpan maxAge)
        {
            using SQLiteConnection conn = new(_connectionString);
            conn.Open();
            using SQLiteCommand cmd = new(
                "DELETE FROM Locks WHERE LockTime < @cutoff", conn);
            cmd.Parameters.AddWithValue("@cutoff", DateTime.Now - maxAge);
            cmd.ExecuteNonQuery();
        }
    }
}
