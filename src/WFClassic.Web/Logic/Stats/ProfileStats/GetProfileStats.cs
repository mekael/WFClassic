using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Stats.ProfileStats
{
    public class GetProfileStats
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }

        [JsonPropertyName("steamId")]
        public string SteamId { get; set; }

        [JsonPropertyName("lookupId")]
        public Guid LookupId { get; set; }
    }
}