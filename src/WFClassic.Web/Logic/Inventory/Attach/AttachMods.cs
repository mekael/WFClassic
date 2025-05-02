using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Inventory.Attach
{
    public class AttachMods
    {
        public Guid AccountId { get; set; }
        public long Nonce { get; set; }
        public IncomingAttachRequest IncomingAttachRequest { get; set; }    
    }

    public class IncomingAttachRequest
    {
        public string Category { get; set; }
        public Weapon Weapon { get; set; }
        public Upgrade[] UpgradesToAttach { get; set; }
        public Upgrade[] UpgradesToDetach { get; set; }
        public int Cost { get; set; }
        public string UpgradeReq { get; set; }
    }

    public class Weapon
    {
        public string ItemType { get; set; }
        public Itemid ItemId { get; set; }
        public int XP { get; set; }
        public int UpgradeVer { get; set; }
        public int UnlockLevel { get; set; }
        public int ExtraCapacity { get; set; }
        public int ExtraRemaining { get; set; }
    }

    public class Itemid
    {
        [JsonPropertyName("$id")]
        public string Id { get; set; }
    }

    public class Upgrade
    {
        public string ItemType { get; set; }
        public Itemid ItemId { get; set; }
        public string UpgradeFingerprint { get; set; }
        public int Slot { get; set; }
        public Itemid ParentId { get; set; }
    }



}
