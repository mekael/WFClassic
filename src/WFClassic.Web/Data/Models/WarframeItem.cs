using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class WarframeItem : EntityBase
    {

        public string ItemType { get; set; }
        public WarframeItemLocation WarframeItemLocation { get; set; }
        public List<WarframeItemComponent> WarframeItemComponents { get; set; }
    
    }
}
