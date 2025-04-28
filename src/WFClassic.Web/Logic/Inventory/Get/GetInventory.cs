using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Inventory.Get
{
    public class GetInventory
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }
    }
}
