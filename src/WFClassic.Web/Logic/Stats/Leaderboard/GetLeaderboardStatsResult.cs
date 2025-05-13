using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Stats.Leaderboard
{
    public class GetLeaderboardStatsResult
    {
        public GetLeaderboardStatsResultJson GetLeaderboardStatsResultJson { get; set; }
        public GetLeaderboardStatsResultStatus GetLeaderboardStatsResultStatus { get; set; }
    }

    public enum GetLeaderboardStatsResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success
    }

    public class GetLeaderboardStatsResultJson
    {
        [JsonPropertyName("players")]
        public List<GetLeaderboardStatsResultItem> players { get; set; }
    }

    public class GetLeaderboardStatsResultItem
    {
        [JsonPropertyName("DisplayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("score")]
        public long score { get; set; }

        [JsonPropertyName("rank")]
        public int rank { get; set; }
    }
}