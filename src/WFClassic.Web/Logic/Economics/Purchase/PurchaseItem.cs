using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Economics.Purchase
{
    public class PurchaseItem
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }

        [JsonPropertyName("productName")]
        public string ProductName { get; set; }

        [JsonPropertyName("usePremium")]
        public int UsePremium { get; set; }

        [JsonPropertyName("durability")]
        // only used for boosters
        // if this is set to 1, then we add the 7 day booster, else add the 3 day one. 
        public int? Durability { get; set; }

    }

}


/*
accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016
&nonce=2809599731345544872&
productName=/Lotus/Powersuits/Volt/Volt&
usePremium=1 
 
 */