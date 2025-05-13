using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class MarketItem : EntityBase
    {
        //TODO: add market area.
        public string ItemType { get; set; }

        public InternalInventoryItemType InternalInventoryItemType { get; set; }
        public int Count { get; set; }
        public int CostInCredits { get; set; }
        public int CostInPlat { get; set; }
        public bool CanBePurchasedWithPlat { get; set; }
        public bool CanBePurchasedWithCredits { get; set; }
    }
}