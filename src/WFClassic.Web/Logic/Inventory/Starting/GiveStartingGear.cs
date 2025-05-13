using Newtonsoft.Json;

namespace WFClassic.Web.Logic.Inventory.Starting
{
    public class GiveStartingGear
    {
        [JsonProperty("accountId")]
        [JsonRequired]
        public Guid AccountId { get; set; }

        [JsonProperty("nonce")]
        [JsonRequired]
        public long Nonce { get; set; }

        [JsonProperty("warframeName")]
        [JsonRequired]
        public string WarframeName { get; set; }
    }
}