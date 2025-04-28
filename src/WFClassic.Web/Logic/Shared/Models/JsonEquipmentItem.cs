

using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Shared.Models
{
    public class JsonEquipmentItem
    {
        [JsonPropertyName("ItemType")]
        public string ItemType { get; set; }

        [JsonPropertyName("ItemId")]
        public MongoId ItemId { get; set; }

        [JsonPropertyName("XP")]
        public long XP { get; set; }

        [JsonPropertyName("UpgradeVer")]
        public long UpgradeVer { get; set; }

        [JsonPropertyName("UnlockLevel")]
        public int UnlockLevel { get; set; }

        [JsonPropertyName("ExtraCapacity")]
        public int ExtraCapacity { get; set; }

        [JsonPropertyName("ExtraRemaining")]
        public int ExtraRemaining { get; set; }
    }

 
}
