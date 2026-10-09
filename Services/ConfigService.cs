using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MuseumCatalog.Services
{
    public class AppConfig
    {
        public string MuseumName { get; set; } = "";
        public string DatabasePath { get; set; } = "";
        public string TemplatePath { get; set; } = "";
        public string PCIdentifier { get; set; } = "";
    }

    public static class ConfigService
    {
        private static readonly string ConfigPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "config.xml");

        public static AppConfig Load()
        {
            if (!File.Exists(ConfigPath))
                return new AppConfig();

            try
            {
                var serializer = new XmlSerializer(typeof(AppConfig));
                using var fs = new FileStream(ConfigPath, FileMode.Open, FileAccess.Read);
                return (AppConfig)serializer.Deserialize(fs);
            }
            catch
            {
                return new AppConfig();
            }
        }

        public static void Save(AppConfig config)
        {
            var serializer = new XmlSerializer(typeof(AppConfig));
            using var fs = new FileStream(ConfigPath, FileMode.Create, FileAccess.Write);
            var settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                Encoding = System.Text.Encoding.UTF8
            };
            using var writer = XmlWriter.Create(fs, settings);
            serializer.Serialize(writer, config);
        }
    }
}
