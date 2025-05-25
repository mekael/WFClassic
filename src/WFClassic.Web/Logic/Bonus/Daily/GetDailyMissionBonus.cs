using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Bonus.Daily
{
    public class GetDailyMissionBonus
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }
    }
}