using System.Text.Json.Serialization;

using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Logic.Inventory.Loadout
{
    public class UpdateLoadout
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }

 

        [JsonIgnore]
        public PlayerLoadout PlayerLoadout { get; set; }
    }
}