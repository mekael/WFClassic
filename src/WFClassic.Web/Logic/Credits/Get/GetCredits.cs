using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Credits.Get
{
    public class GetCredits
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }
    }
}