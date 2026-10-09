using System;

namespace MuseumCatalog.Models
{
    public class AuditLog
    {
        public int ID { get; set; }
        public DateTime OperationDate { get; set; }
        public string PCIdentifier { get; set; }
        public string OperationType { get; set; }
        public int ExhibitID { get; set; }

        // Снимок состояния экспоната до изменения (без фото)
        public string Cipher { get; set; }
        public string KPNumber { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string Source { get; set; }
        public string ActNumber { get; set; }
        public string MaterialTechnique { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Condition { get; set; }
        public int? StoragePlaceID { get; set; }

        /// <summary>
        /// Восстанавливает объект Exhibit из снимка (без фото).
        /// </summary>
        public Exhibit ToExhibit()
        {
            return new Exhibit
            {
                ID = ExhibitID,
                Cipher = Cipher ?? "",
                KPNumber = KPNumber ?? "",
                TimeStamp = TimeStamp,
                Source = Source ?? "",
                ActNumber = ActNumber ?? "",
                MaterialTechnique = MaterialTechnique ?? "",
                ItemName = ItemName ?? "",
                Description = Description ?? "",
                Size = Size ?? "",
                Condition = Condition ?? "",
                StoragePlaceID = StoragePlaceID,
                Photo = null
            };
        }

        /// <summary>
        /// True, если снимок содержит данные экспоната.
        /// </summary>
        public bool HasSnapshot =>
            !string.IsNullOrEmpty(Cipher) || !string.IsNullOrEmpty(ItemName) ||
            !string.IsNullOrEmpty(KPNumber) || ExhibitID > 0;
    }
}
