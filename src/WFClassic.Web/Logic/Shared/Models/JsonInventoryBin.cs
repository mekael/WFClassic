using Newtonsoft.Json;

namespace WFClassic.Web.Logic.Shared.Models
{
    public class JsonInventoryBin
    {
        [JsonProperty("Slots")]
        public int Slots { get; set; }
        [JsonProperty("Extra")]
        public int Extra { get; set; }
    }
}
