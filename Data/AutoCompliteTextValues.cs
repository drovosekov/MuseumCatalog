using System.Collections.Generic;
using System.Data.SQLite;

namespace MuseumCatalog.Data
{
    public static class AutoCompliteTextValues
    {
        // Загрузка истории для конкретного текстового поля
        public static List<string> GetHistory(string dbPath, string fieldName)
        {
            var list = new List<string>();
            using SQLiteConnection conn = new(DatabaseService.GetConnectionString(dbPath));
            conn.Open();
            using SQLiteCommand cmd = new("SELECT Value FROM FieldHistory WHERE FieldName = " +
                                          "@FieldName ORDER BY Id DESC;", conn);
            cmd.Parameters.AddWithValue("@FieldName", fieldName);
            using SQLiteDataReader r = cmd.ExecuteReader();
            while (r.Read()) list.Add(r.GetString(0));
            return list;

        }

        // Сохранение нового значения
        public static void SaveValue(string dbPath, string fieldName, string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return;

            using SQLiteConnection conn = new(DatabaseService.GetConnectionString(dbPath));
            conn.Open();
            using SQLiteCommand cmd = new("INSERT OR IGNORE INTO FieldHistory (FieldName, Value) " +
                                          "VALUES (@FieldName, @Value);", conn);
            cmd.Parameters.AddWithValue("@FieldName", fieldName);
            cmd.Parameters.AddWithValue("@Value", value);
            cmd.ExecuteNonQuery();
        }
    }
}
