using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Bonus.Rewards
{
    public class GetLoginRewards
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }
    }
}
