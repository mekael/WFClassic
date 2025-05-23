using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Economics.Purchase
{
    public class PurchaseItem
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }
        
        [JsonPropertyName("accountId")]
        public long Nonce { get; set; }

        [JsonPropertyName("productName")]
        public string ProductName { get; set; }

        [JsonPropertyName("usePremium")]
        public bool UsePremium { get; set; }

    }

}