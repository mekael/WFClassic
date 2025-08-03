using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class WarframeItemComponent : EntityBase
    {

        public Guid WarframeItemId { get; set; }
        public WarframeItem WarframeItem { get; set; }

        public string ItemType { get; set; }
        public string ItemName { get; set; }
        public InternalInventoryItemType InternalInventoryItemType { get; set; }
        public int Count { get; set; }
        public bool IsUniqueItem { get; set; }


        public int UpgradeVer { get; set; }
        public int XP { get; set; }
        public int UnlockLevel { get; set; }
        public int ExtraCapacity { get; set; }
        public int ExtraRemaining { get; set; }
        public string UpgradeFingerprint { get; set; }
        public int Charge { get; set; }


        // if we are buying a frame, sentinel, or a weapon, then we need to add at least one bin for that 
        // specific item.  Since items are only associated with one bin, we don't need to have a separate table. 
        public bool AddInventoryBin { get; set; }
        public InventoryBinType? InventoryBinTypeToAdd { get; set; }
        public int NumberOfBinsToAdd { get; set; }


    }
}
