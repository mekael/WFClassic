using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Logic.UI.Inventory.AddList
{
    public class GetAllWaframeItemsResult
    {
        public GetAllWarframeItemsResultStatus GetAllWaframeItemsResultStatus { get; set; }

        public List<GetAllWarframeItemsResultDetailItem> GetAllWarframeItemsResultDetailItems { get; set; } = new List<GetAllWarframeItemsResultDetailItem>();
    }

    public enum GetAllWarframeItemsResultStatus
    {
        MappingErrors,
        DatabaseErrors,
        Success
    }

    public class GetAllWarframeItemsResultDetailItem
    {
        public string ItemName { get; set; }
        public WarframeItemLocation WarframeItemLocation { get; set; }

        public List<GetAllWarframeItemsResultDetailItemComponent> GetAllWarframeItemsResultDetailItemComponents { get; set; }
    }

    public class GetAllWarframeItemsResultDetailItemComponent
    {
        public string ItemType { get; set; }
        public string ItemName { get; set; }
        public InternalInventoryItemType InternalInventoryItemType { get; set; }
        public int UnlockLevel { get; set; }
        public bool AddInventoryBin { get; set; }
        public InventoryBinType? InventoryBinTypeToAdd { get; set; }
        public int NumberOfBinsToAdd { get; set; }
    }
}