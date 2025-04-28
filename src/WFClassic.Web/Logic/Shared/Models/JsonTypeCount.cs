using Newtonsoft.Json;

namespace WFClassic.Web.Logic.Shared.Models
{
    public class JsonTypeCount
    {
        [JsonProperty("ItemType")]
        public string ItemType { get; set; }
        
        [JsonProperty("ItemCount")]
        public int ItemCount { get; set; }
    }
}
