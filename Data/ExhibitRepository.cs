using System;
using System.Collections.Generic;
using System.Data.SQLite;
using MuseumCatalog.Models;

namespace MuseumCatalog.Data
{
    public class ExhibitRepository
    {
        private readonly string _connectionString;

        public ExhibitRepository(string dbPath)
        {
            _connectionString = DatabaseService.GetConnectionString(dbPath);
        }

        public List<Exhibit> GetAll(string filterCipher = null,
            string filterKP = null, string filterAct = null,
            string filterName = null, string filterDesc = null,
            DateTime? dateFrom = null, DateTime? dateTo = null,
            int? storagePlaceID = null)
        {
            var results = new List<Exhibit>();
            var where = new List<string>();
            var parameters = new List<SQLiteParameter>();

            if (!string.IsNullOrWhiteSpace(filterCipher))
            {
                where.Add("e.Cipher LIKE @p_Cipher");
                parameters.Add(new SQLiteParameter("@p_Cipher", $"%{filterCipher}%"));
            }
            if (!string.IsNullOrWhiteSpace(filterKP))
            {
                where.Add("e.KPNumber LIKE @p_KP");
                parameters.Add(new SQLiteParameter("@p_KP", $"%{filterKP}%"));
            }
            if (!string.IsNullOrWhiteSpace(filterAct))
            {
                where.Add("e.ActNumber LIKE @p_Act");
                parameters.Add(new SQLiteParameter("@p_Act", $"%{filterAct}%"));
            }
            if (!string.IsNullOrWhiteSpace(filterName))
            {
                where.Add("e.ItemName LIKE @p_Name");
                parameters.Add(new SQLiteParameter("@p_Name", $"%{filterName}%"));
            }
            if (!string.IsNullOrWhiteSpace(filterDesc))
            {
                where.Add("e.Description LIKE @p_Desc");
                parameters.Add(new SQLiteParameter("@p_Desc", $"%{filterDesc}%"));
            }
            if (dateFrom.HasValue)
            {
                where.Add("e.TimeStamp >= @p_DateFrom");
                parameters.Add(new SQLiteParameter("@p_DateFrom", dateFrom.Value));
            }
            if (dateTo.HasValue)
            {
                where.Add("e.TimeStamp <= @p_DateTo");
                parameters.Add(new SQLiteParameter("@p_DateTo", dateTo.Value));
            }
            if (storagePlaceID.HasValue)
            {
                where.Add("e.StoragePlaceID = @p_Place");
                parameters.Add(new SQLiteParameter("@p_Place", storagePlaceID.Value));
            }

            string sql = @"SELECT e.*, s.PlaceName
                          FROM tbl_Exhibits e
                          LEFT JOIN tbl_StoragePlaces s ON e.StoragePlaceID = s.ID";
            if (where.Count > 0)
                sql += " WHERE " + string.Join(" AND ", where);
            sql += " ORDER BY e.ID DESC";

            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand(sql, conn);
            foreach (var p in parameters)
                cmd.Parameters.Add(p);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                results.Add(MapExhibit(reader));
            }
            return results;
        }

        public Exhibit GetById(int id)
        {
            const string sql = @"SELECT e.*, s.PlaceName
                                FROM tbl_Exhibits e
                                LEFT JOIN tbl_StoragePlaces s ON e.StoragePlaceID = s.ID
                                WHERE e.ID = @id";

            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
                return MapExhibit(reader);
            return null;
        }

        public int Insert(Exhibit ex)
        {
            const string sql = @"INSERT INTO tbl_Exhibits
                (Cipher, KPNumber, TimeStamp, Source, ActNumber,
                 MaterialTechnique, ItemName, Description, Size,
                 Condition, StoragePlaceID, Photo)
                VALUES (@Cipher, @KPNumber, @TimeStamp, @Source, @ActNumber,
                        @MaterialTechnique, @ItemName, @Description, @Size,
                        @Condition, @StoragePlaceID, @Photo);
                SELECT last_insert_rowid();";

            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand(sql, conn);
            AddParameters(cmd, ex);
            return (int)(long)cmd.ExecuteScalar();
        }

        public void Update(Exhibit ex)
        {
            const string sql = @"UPDATE tbl_Exhibits SET
                Cipher = @Cipher, KPNumber = @KPNumber, TimeStamp = @TimeStamp,
                Source = @Source, ActNumber = @ActNumber,
                MaterialTechnique = @MaterialTechnique, ItemName = @ItemName,
                Description = @Description, Size = @Size, Condition = @Condition,
                StoragePlaceID = @StoragePlaceID, Photo = @Photo
                WHERE ID = @ID";

            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand(sql, conn);
            AddParameters(cmd, ex);
            cmd.Parameters.AddWithValue("@ID", ex.ID);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand("DELETE FROM tbl_Exhibits WHERE ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        private void AddParameters(SQLiteCommand cmd, Exhibit ex)
        {
            cmd.Parameters.AddWithValue("@Cipher", ex.Cipher ?? "");
            cmd.Parameters.AddWithValue("@KPNumber", ex.KPNumber ?? "");
            cmd.Parameters.AddWithValue("@TimeStamp", (object)ex.TimeStamp ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Source", ex.Source ?? "");
            cmd.Parameters.AddWithValue("@ActNumber", ex.ActNumber ?? "");
            cmd.Parameters.AddWithValue("@MaterialTechnique", ex.MaterialTechnique ?? "");
            cmd.Parameters.AddWithValue("@ItemName", ex.ItemName ?? "");
            cmd.Parameters.AddWithValue("@Description", ex.Description ?? "");
            cmd.Parameters.AddWithValue("@Size", ex.Size ?? "");
            cmd.Parameters.AddWithValue("@Condition", ex.Condition ?? "");
            cmd.Parameters.AddWithValue("@StoragePlaceID", (object)ex.StoragePlaceID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Photo", (object)ex.Photo ?? DBNull.Value);
        }

        private Exhibit MapExhibit(SQLiteDataReader r)
        {
            return new Exhibit
            {
                ID = r.GetInt32(r.GetOrdinal("ID")),
                Cipher = r["Cipher"]?.ToString() ?? "",
                KPNumber = r["KPNumber"]?.ToString() ?? "",
                TimeStamp = r["TimeStamp"] as DateTime?,
                Source = r["Source"]?.ToString() ?? "",
                ActNumber = r["ActNumber"]?.ToString() ?? "",
                MaterialTechnique = r["MaterialTechnique"]?.ToString() ?? "",
                ItemName = r["ItemName"]?.ToString() ?? "",
                Description = r["Description"]?.ToString() ?? "",
                Size = r["Size"]?.ToString() ?? "",
                Condition = r["Condition"]?.ToString() ?? "",
                StoragePlaceID = r.IsDBNull(r.GetOrdinal("StoragePlaceID"))
                                ?  null
                                : Convert.ToInt32(r["StoragePlaceID"]),
                StoragePlaceName = r["PlaceName"]?.ToString() ?? "",
                Photo = r["Photo"] as byte[]
            };
        }
    }
}
