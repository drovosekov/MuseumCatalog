using System.Collections.Generic;
using System.Data.SQLite;
using MuseumCatalog.Models;

namespace MuseumCatalog.Data
{
    public class StoragePlaceRepository
    {
        private readonly string _connectionString;

        public StoragePlaceRepository(string dbPath)
        {
            _connectionString = DatabaseService.GetConnectionString(dbPath);
        }

        public List<StoragePlace> GetAll()
        {
            var results = new List<StoragePlace>();
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand(
                "SELECT ID, PlaceName FROM tbl_StoragePlaces ORDER BY PlaceName", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                results.Add(new StoragePlace
                {
                    ID = reader.GetInt32(0),
                    PlaceName = reader.IsDBNull(1) ? "" : reader.GetString(1)
                });
            }
            return results;
        }

        public void Add(string placeName)
        {
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand(
                "INSERT INTO tbl_StoragePlaces (PlaceName) VALUES (@name)", conn);
            cmd.Parameters.AddWithValue("@name", placeName);
            cmd.ExecuteNonQuery();
        }

        public void Update(int id, string placeName)
        {
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand(
                "UPDATE tbl_StoragePlaces SET PlaceName = @name WHERE ID = @id", conn);
            cmd.Parameters.AddWithValue("@name", placeName);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand(
                "DELETE FROM tbl_StoragePlaces WHERE ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
