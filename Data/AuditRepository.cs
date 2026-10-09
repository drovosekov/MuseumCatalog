using MuseumCatalog.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace MuseumCatalog.Data
{
    public class AuditRepository
    {
        private readonly string _connStr;

        public AuditRepository(string dbPath)
        {
            _connStr = DatabaseService.GetConnectionString(dbPath);
            //EnsureColumns();
        }

        /*private void EnsureColumns()
        {
            // Добавляем колонки снимка, если их нет
            string[] snapshotColumns = {
                "Cipher TEXT DEFAULT ''",
                "KPNumber TEXT DEFAULT ''",
                "TimeStamp TEXT",
                "Source TEXT DEFAULT ''",
                "ActNumber TEXT DEFAULT ''",
                "MaterialTechnique TEXT DEFAULT ''",
                "ItemName TEXT DEFAULT ''",
                "Description TEXT DEFAULT ''",
                "Size TEXT DEFAULT ''",
                "Condition TEXT DEFAULT ''",
                "StoragePlaceID INTEGER"
            };

            using SQLiteConnection conn = new(_connStr);
            conn.Open();

            // Получаем существующие колонки
            var existing = new HashSet<string>();
            using (SQLiteCommand cmd = new("PRAGMA table_info(AuditLog);", conn))
            using (SQLiteDataReader r = cmd.ExecuteReader())
            {
                while (r.Read())
                    existing.Add(r.GetString(1));
            }

            foreach (string colDef in snapshotColumns)
            {
                string colName = colDef.Split(' ')[0];
                if (!existing.Contains(colName))
                {
                    using SQLiteCommand alter = new(
                        $"ALTER TABLE AuditLog ADD COLUMN {colDef};", conn);
                    alter.ExecuteNonQuery();
                }
            }
        }
        */

        public void Log(string operation, string pcId, int exhibitId)
        {
            using SQLiteConnection conn = new(_connStr);
            conn.Open();
            using SQLiteCommand cmd = new(@"
                INSERT INTO AuditLog (OperationDate, PCIdentifier, OperationType, ExhibitID)
                VALUES (@date, @pc, @op, @exh);", conn);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@pc", pcId ?? "");
            cmd.Parameters.AddWithValue("@op", operation);
            cmd.Parameters.AddWithValue("@exh", exhibitId);
            cmd.ExecuteNonQuery();
        }

        public void LogWithSnapshot(string operation, string pcId, Exhibit exhibit)
        {
            using SQLiteConnection conn = new(_connStr);
            conn.Open();
            using SQLiteCommand cmd = new(@"
                INSERT INTO AuditLog (
                    OperationDate, PCIdentifier, OperationType, ExhibitID,
                    Cipher, KPNumber, TimeStamp, Source, ActNumber,
                    MaterialTechnique, ItemName, Description, Size, Condition, StoragePlaceID
                ) VALUES (
                    @date, @pc, @op, @exh,
                    @cipher, @kp, @ts, @source, @act,
                    @mat, @name, @desc, @size, @cond, @place
                );", conn);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@pc", pcId);
            cmd.Parameters.AddWithValue("@op", operation);
            cmd.Parameters.AddWithValue("@exh", exhibit.ID);
            cmd.Parameters.AddWithValue("@cipher", exhibit.Cipher);
            cmd.Parameters.AddWithValue("@kp", exhibit.KPNumber);
            cmd.Parameters.AddWithValue("@ts", exhibit.TimeStamp?.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@source", exhibit.Source);
            cmd.Parameters.AddWithValue("@act", exhibit.ActNumber);
            cmd.Parameters.AddWithValue("@mat", exhibit.MaterialTechnique);
            cmd.Parameters.AddWithValue("@name", exhibit.ItemName);
            cmd.Parameters.AddWithValue("@desc", exhibit.Description);
            cmd.Parameters.AddWithValue("@size", exhibit.Size);
            cmd.Parameters.AddWithValue("@cond", exhibit.Condition);
            cmd.Parameters.AddWithValue("@place", exhibit.StoragePlaceID);
            cmd.ExecuteNonQuery();
        }
        public void ClearAll()
        {
            using SQLiteConnection conn = new(_connStr);
            conn.Open();
            using SQLiteCommand cmd = new("DELETE FROM AuditLog;", conn);
            cmd.ExecuteNonQuery();
        }

        public List<AuditLog> GetAll()
        {
            var list = new List<AuditLog>();
            using SQLiteConnection conn = new(_connStr);
            conn.Open();
            using SQLiteCommand cmd = new(@"
                SELECT ID, OperationDate, PCIdentifier, OperationType, ExhibitID,
                       Cipher, KPNumber, TimeStamp, Source, ActNumber,
                       MaterialTechnique, ItemName, Description, Size, Condition, StoragePlaceID
                FROM AuditLog ORDER BY ID DESC;", conn);
            using SQLiteDataReader r = cmd.ExecuteReader();
            while (r.Read()) list.Add(ReadLog(r));
            return list;
        }

        public List<AuditLog> GetFiltered(string pcFilter, string opFilter, DateTime? dateFrom, DateTime? dateTo)
        {
            var list = new List<AuditLog>();
            using SQLiteConnection conn = new(_connStr);
            conn.Open();

            string sql = @"
                SELECT ID, OperationDate, PCIdentifier, OperationType, ExhibitID,
                       Cipher, KPNumber, TimeStamp, Source, ActNumber,
                       MaterialTechnique, ItemName, Description, Size, Condition, StoragePlaceID
                FROM AuditLog WHERE 1=1";

            if (!string.IsNullOrEmpty(pcFilter))
                sql += " AND PCIdentifier LIKE @pcFilter";
            if (!string.IsNullOrEmpty(opFilter))
                sql += " AND OperationType LIKE @opFilter";
            if (dateFrom.HasValue)
                sql += " AND OperationDate >= @dateFrom";
            if (dateTo.HasValue)
                sql += " AND OperationDate <= @dateTo";
            sql += " ORDER BY ID DESC";

            using SQLiteCommand cmd = new(sql, conn);
            if (!string.IsNullOrEmpty(pcFilter))
                cmd.Parameters.AddWithValue("@pcFilter", "%" + pcFilter + "%");
            if (!string.IsNullOrEmpty(opFilter))
                cmd.Parameters.AddWithValue("@opFilter", "%" + opFilter + "%");
            if (dateFrom.HasValue)
                cmd.Parameters.AddWithValue("@dateFrom", dateFrom.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            if (dateTo.HasValue)
                cmd.Parameters.AddWithValue("@dateTo", dateTo.Value.ToString("yyyy-MM-dd HH:mm:ss"));

            using SQLiteDataReader r = cmd.ExecuteReader();
            while (r.Read()) list.Add(ReadLog(r));
            return list;
        }

        public AuditLog GetById(int id)
        {
            using SQLiteConnection conn = new(_connStr);
            conn.Open();
            using SQLiteCommand cmd = new(@"
                SELECT ID, OperationDate, PCIdentifier, OperationType, ExhibitID,
                       Cipher, KPNumber, TimeStamp, Source, ActNumber,
                       MaterialTechnique, ItemName, Description, Size, Condition, StoragePlaceID
                FROM AuditLog WHERE ID = @id;", conn);
            cmd.Parameters.AddWithValue("@id", id);
            using SQLiteDataReader r = cmd.ExecuteReader();
            if (r.Read()) return ReadLog(r);
            return null;
        }

        private static AuditLog ReadLog(SQLiteDataReader r)
        {
            var log = new AuditLog
            {
                ID = r.GetInt32(0),
                OperationDate = r.GetDateTime(1),
                PCIdentifier = r.IsDBNull(2) ? "" : r.GetString(2),
                OperationType = r.IsDBNull(3) ? "" : r.GetString(3),
                ExhibitID = r.IsDBNull(4) ? 0 : r.GetInt32(4),
                Cipher = r.IsDBNull(5) ? "" : r.GetString(5),
                KPNumber = r.IsDBNull(6) ? "" : r.GetString(6),
                TimeStamp = r.IsDBNull(7) ? null : DateTime.Parse(r.GetString(7)),
                Source = r.IsDBNull(8) ? "" : r.GetString(8),
                ActNumber = r.IsDBNull(9) ? "" : r.GetString(9),
                MaterialTechnique = r.IsDBNull(10) ? "" : r.GetString(10),
                ItemName = r.IsDBNull(11) ? "" : r.GetString(11),
                Description = r.IsDBNull(12) ? "" : r.GetString(12),
                Size = r.IsDBNull(13) ? "" : r.GetString(13),
                Condition = r.IsDBNull(14) ? "" : r.GetString(14),
                StoragePlaceID = r.IsDBNull(15) ? null : (int?)r.GetInt32(15)
            };
            return log;
        }
    }
}
