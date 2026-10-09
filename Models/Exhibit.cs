using System;
using System.ComponentModel;

namespace MuseumCatalog.Models
{
    public class Exhibit
    {
        public int ID { get; set; }
        public string Cipher { get; set; } = "";
        public string KPNumber { get; set; } = "";
        public DateTime? TimeStamp { get; set; }
        public string Source { get; set; } = "";
        public string ActNumber { get; set; } = "";
        public string MaterialTechnique { get; set; } = "";
        public string ItemName { get; set; } = "";
        public string Description { get; set; } = "";
        public string Size { get; set; } = "";
        public string Condition { get; set; } = ""; 
        public int? StoragePlaceID { get; set; }
        public string StoragePlaceName { get; set; } = "";
        [Browsable(false)]
        public byte[] Photo { get; set; }
    }

    public class StoragePlace
    {
        public int ID { get; set; }
        public string PlaceName { get; set; } = "";
    }

    public class AuditEntry
    {
        public int ID { get; set; }
        public DateTime OperationDate { get; set; }
        public string PCIdentifier { get; set; } = "";
        public string OperationType { get; set; } = "";
        public int? ExhibitID { get; set; }
    }

    public class LockEntry
    {
        public int ID { get; set; }
        public int ExhibitID { get; set; }
        public string PCIdentifier { get; set; } = "";
        public DateTime LockTime { get; set; }
    }
}
