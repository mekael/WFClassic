using Newtonsoft.Json;

namespace WFClassic.Web.Logic.Shared.Models
{
    public class JsonXpInfoItem
    {
        [JsonProperty("ItemType")]
        public string ItemType { get; set; }

        [JsonProperty("XP")]
        public long XP { get; set; }
    }
}
