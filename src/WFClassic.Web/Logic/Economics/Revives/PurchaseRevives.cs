using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Economics.Revives
{
    public class PurchaseRevives
    {
        public Guid AccountId { get; set; }
        public long Nonce { get; set; }
        public IncomingRefillRevivesJsonObject IncomingRefillRevivesJsonObject { get; set; }
    }

    public class IncomingRefillRevivesJsonObject
    {
        [JsonPropertyName("SuitId")]
        public Suitid SuitId { get; set; }
        [JsonPropertyName("Count")]
        public int Count { get; set; }
    }

    public class Suitid
    {
        [JsonPropertyName("$id")]
        public Guid id { get; set; }
    }
}