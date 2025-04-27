namespace WFClassic.Web.Data.Models
{
    public class InventoryItemAttachment : EntityBase
    {
        public int Slot { get; set; }
        public Guid AttachedInventoryItemId { get; set; }
        public InventoryItem AttachedInventoryItem { get; set; }
        public Guid ParentInventoryItemId { get; set; }
        public InventoryItem ParentInventoryItem { get; set; }
    }
}
