using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Inventory.Loadout
{
    public class UpdateLoadout
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }

        [JsonIgnore]
        public string LoadoutState { get; set; }
    }
}
