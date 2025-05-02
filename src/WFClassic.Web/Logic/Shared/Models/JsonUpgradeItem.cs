using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Shared.Models
{
    public class JsonUpgradeItem
    {
        [JsonPropertyName("ItemType")]
        public string ItemType { get; set; }

        [JsonPropertyName("ItemId")]
        public MongoId ItemId { get; set; }

        [JsonPropertyName("ParentId")]
        public MongoId ParentId { get; set; }

        [JsonPropertyName("Slot")]
        public int? Slot { get; set; }

        [JsonPropertyName("UpgradeFingerprint")]
        public string UpgradeFingerPrint{get;set;}

    }
}
