using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Economics.Slots
{
    public class PurchaseSlots
    {
        public Guid AccountId { get; set; }
        public long Nonce { get; set; }
        public string IncomingPurchaseSlotsJsonObject { get; set; }
    }

  

    public class IncomingPurchaseSuitsJsonObject
    {
        [JsonPropertyName("Bin")]
        public string Bin { get; set; }
    }
}