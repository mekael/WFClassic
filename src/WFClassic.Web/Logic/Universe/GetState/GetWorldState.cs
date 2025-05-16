using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Universe.GetState
{
    public class GetWorldState
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }
    }
}
