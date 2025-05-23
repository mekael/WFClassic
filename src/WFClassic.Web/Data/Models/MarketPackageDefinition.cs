using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class MarketPackageDefinition : EntityBase
    {
        public string ItemType { get; set; }
        public bool CanBePurchasedMultipleTimes { get; set; }
        public int CostInCredits { get; set; }
        public int CostInPlat { get; set; }
        public bool CanBePurchasedWithPlat { get; set; }
        public bool CanBePurchasedWithCredits { get; set; }

        public List<MarketPackageItemDefinition> MarketPackageItemDefinitions { get; set; }
    }
}