using System.Text.Json.Serialization;

using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class InventoryItem : EntityBase
    {
        [JsonIgnore]
        public Guid PlayerId { get; set; }
        [JsonIgnore]
        public Player Player { get; set; }
        public InternalInventoryItemType InternalInventoryItemType { get; set; }
        public string ItemType { get; set; }
        public string ItemName { get; set; }
        public int ItemCount { get; set; }

        public int UpgradeVer { get; set; }
        public int XP { get; set; }
        public int UnlockLevel { get; set; }
        public int ExtraCapacity { get; set; }
        public int ExtraRemaining { get; set; }
        public string UpgradeFingerprint { get; set; }
        public int Charge { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}