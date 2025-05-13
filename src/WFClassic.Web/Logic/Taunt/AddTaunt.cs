using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Taunt
{
    public class AddTaunt
    {
        public Guid AccountId { get; set; }

        public long Nonce { get; set; }
        public IncomingAddTaunt IncomingAddTaunt { get; set; }
    }

    public class IncomingAddTaunt
    {
        [JsonPropertyName("node")]
        public string Node { get; set; }
    }
}