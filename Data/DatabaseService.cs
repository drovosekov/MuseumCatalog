using System.Data.SQLite;

namespace MuseumCatalog.Data
{
    public static class DatabaseService
    {
        public static void InitializeDatabase(string dbPath)
        {
            // Connection string с WAL-режимом и таймаутом блокировки
            string connStr = GetConnectionString(dbPath);

            using SQLiteConnection conn = new (connStr);
            conn.Open();

            // Включаем WAL — позволяет читать и писать одновременно из разных процессов
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "PRAGMA journal_mode=WAL;";
                cmd.ExecuteNonQuery();
            }

            // Нормальный режим синхронизации — достаточно быстрый и надёжный
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "PRAGMA synchronous=NORMAL;";
                cmd.ExecuteNonQuery();
            }

            // Таблица экспонатов
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Exhibits (
                            ID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Cipher TEXT,
                            KPNumber TEXT,
                            ItemName TEXT,
                            Description TEXT,
                            TimeStamp TEXT,
                            Source TEXT,
                            ActNumber TEXT,
                            MaterialTechnique TEXT,
                            Size TEXT,
                            Condition TEXT,
                            StoragePlaceID INTEGER,
                            Photo BLOB
                        );";
                cmd.ExecuteNonQuery();
            }

            // Таблица мест хранения
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS StoragePlaces (
                            ID INTEGER PRIMARY KEY AUTOINCREMENT,
                            PlaceName TEXT UNIQUE
                        );";
                cmd.ExecuteNonQuery();
            }

            // Таблица журнала
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS AuditLog (
                            ID INTEGER PRIMARY KEY AUTOINCREMENT,
                            OperationDate TEXT,
                            PCIdentifier TEXT,
                            OperationType TEXT,
                            ExhibitID INTEGER,
                            Cipher TEXT DEFAULT '',
                            KPNumber TEXT DEFAULT '',
                            TimeStamp TEXT,
                            Source TEXT DEFAULT '',
                            ActNumber TEXT DEFAULT '',
                            MaterialTechnique TEXT DEFAULT '',
                            ItemName TEXT DEFAULT '',
                            Description TEXT DEFAULT '',
                            Size TEXT DEFAULT '',
                            Condition TEXT DEFAULT '',
                            StoragePlaceID INTEGER
                        ); ";
                cmd.ExecuteNonQuery();
            }

            // Таблица блокировок
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Locks (
                            ExhibitID INTEGER PRIMARY KEY,
                            PCIdentifier TEXT,
                            LockTime TEXT
                        );";
                cmd.ExecuteNonQuery();
            }

            // Таблица автозаполнения текстовых полей
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                                CREATE TABLE IF NOT EXISTS FieldHistory (
                                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    FieldName TEXT NOT NULL,
                                    Value TEXT NOT NULL,
                                    UNIQUE(FieldName, Value)  
                                );";
                cmd.ExecuteNonQuery();
            }
             
        }

        /// <summary>
        /// Возвращает строку подключения с WAL и BusyTimeout для использования в репозиториях.
        /// </summary>
        public static string GetConnectionString(string dbPath)
        {
            return $"Data Source={dbPath};Version=3;BusyTimeout=5000;";
        }
    }
}
