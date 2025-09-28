using System.Text.Json.Serialization;

using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Logic.Inventory.WarframeItemAddition
{
    public class AddWarframeItem
    {
        public Guid AccountId { get; set; }
        public string ItemType { get; set; }
        public WarframeItemLocation WarframeItemLocation { get; set; }
        public Guid WarframeItemId { get; set; }
        public int NumberOfDaysForBooster { get; set; } = 3;
    }
}