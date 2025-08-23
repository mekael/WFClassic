using System.Text.Json.Serialization;

using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class InventoryBin : EntityBase
    {
        [JsonIgnore]
        public Guid InventoryId { get; set; }
        public Player Inventory { get; set; }
        public InventoryBinType InventoryBinType { get; set; }
        public int Slots { get; set; }
        public int Extra { get; set; }
    }
}