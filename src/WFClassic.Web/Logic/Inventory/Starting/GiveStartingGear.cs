using System.Text.Json;
using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Inventory.Starting
{
    public class GiveStartingGear
    {
        [JsonPropertyName("accountId")]
        [JsonRequired]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        [JsonRequired]
        public long Nonce { get; set; }

        [JsonPropertyName("warframeName")]
        [JsonRequired]
        public string WarframeName { get; set; }
    }
}