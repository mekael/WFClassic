using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Foundry.Pending
{
    public class CheckPendingRecipesQuery
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }

        [JsonPropertyName("steamId")]
        public long SteamId { get; set; }
    }

}
