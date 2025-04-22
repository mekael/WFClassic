using Newtonsoft.Json;

namespace WFClassic.Web.Logic.Credits.Get
{
    public class GetCredits
    {
        [JsonProperty("accountId")]
        public Guid AccountId { get; set; }
        [JsonProperty("nonce")]
        public long Nonce { get; set; }
    }
}
