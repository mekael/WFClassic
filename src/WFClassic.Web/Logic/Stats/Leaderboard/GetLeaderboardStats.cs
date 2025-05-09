
using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Stats.Leaderboard
{
    public class GetLeaderboardStats
    {

        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }

        [JsonPropertyName("steamId")]
        public string SteamId { get; set; }

        [JsonPropertyName("field")]
        public string Field { get; set; }

        [JsonPropertyName("before")]
        public int Before { get; set; }

        [JsonPropertyName("after")]
        public int After { get; set; }

        [JsonPropertyName("pivotAccountId")]
        public Guid PivotAccountId { get; set; }

 

    }
}
