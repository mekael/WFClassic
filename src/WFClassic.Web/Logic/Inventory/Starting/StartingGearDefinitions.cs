using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Inventory.Starting
{
    public static class StartingGearDefinitions
    {
        public static List<InventoryItem> GetStartingCards(string warframeName)
        {
            if (warframeName == "Excalibur")
            {
                return new List<InventoryItem>() {
                            new InventoryItem() { ItemCount = 1, InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Upgrades, UpgradeFingerprint="lvl=0|",  ItemType = "/Lotus/Powersuits/Excalibur/RadialBlindAbilityCard", ItemName = "Radial Blind", },
                            new InventoryItem() { ItemCount = 1, InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Upgrades, UpgradeFingerprint="lvl=0|", ItemType = "/Lotus/Powersuits/Excalibur/RadialJavelinAbilityCard", ItemName = "Radial Javelin", },
                            new InventoryItem() { ItemCount = 1, InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Upgrades, UpgradeFingerprint="lvl=0|", ItemType = "/Lotus/Powersuits/Excalibur/SlashDashAbilityCard", ItemName = "Slash Dash", },
                            new InventoryItem() { ItemCount = 1, InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Upgrades, UpgradeFingerprint="lvl=0|", ItemType = "/Lotus/Powersuits/Excalibur/SuperJumpAbilityCard", ItemName = "Super Jump", }
                 };
            }
            else if (warframeName == "Mag")
            {
                return new List<InventoryItem>() {
                         new InventoryItem() { ItemCount = 1, InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Upgrades, UpgradeFingerprint="lvl=0|", ItemType = "/Lotus/Powersuits/Mag/BulletAttractorAbilityCard", ItemName = "Bullet Attractor", },
                         new InventoryItem() { ItemCount = 1, InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Upgrades, UpgradeFingerprint="lvl=0|", ItemType = "/Lotus/Powersuits/Mag/CrushAbilityCard", ItemName = "Crush", },
                         new InventoryItem() { ItemCount = 1, InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Upgrades, UpgradeFingerprint="lvl=0|", ItemType = "/Lotus/Powersuits/Mag/PullAbilityCard", ItemName = "Pull", },
                         new InventoryItem() { ItemCount = 1, InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Upgrades, UpgradeFingerprint="lvl=0|", ItemType = "/Lotus/Powersuits/Mag/ShieldRegenAbilityCard", ItemName = "Shield Polarize", }
                    };
            }
            else if (warframeName == "Loki")
            {
                return new List<InventoryItem>() {
                            new InventoryItem() { ItemCount = 1, InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Upgrades, UpgradeFingerprint="lvl=0|", ItemType = "/Lotus/Powersuits/Loki/DecoyAbilityCard", ItemName = "Decoy", },
                            new InventoryItem() { ItemCount = 1, InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Upgrades, UpgradeFingerprint="lvl=0|", ItemType = "/Lotus/Powersuits/Loki/DisarmAbilityCard", ItemName = "Radial Disarm", },
                            new InventoryItem() { ItemCount = 1, InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Upgrades, UpgradeFingerprint="lvl=0|", ItemType = "/Lotus/Powersuits/Loki/InvisibilityAbilityCard", ItemName = "Invisibility", },
                            new InventoryItem() { ItemCount = 1, InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Upgrades, UpgradeFingerprint="lvl=0|", ItemType = "/Lotus/Powersuits/Loki/SwitchAbilityCard", ItemName = "Switch Teleport", }
                                                };
            }

            return new List<InventoryItem>();
        }

        public static List<InventoryItem> GetStartingWeapons()
        {
            return new List<InventoryItem>()
            {
                new InventoryItem()
            {
                ItemCount = 1,
                InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Melee,
                ItemType = "/Lotus/Weapons/Tenno/Melee/LongSword/LongSword",
                ItemName = "LongSword",
            },
              new InventoryItem()
            {
                ItemCount = 1,
                InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Pistols,
                ItemType = "/Lotus/Weapons/Tenno/Pistol/Pistol",
                ItemName = "Lato",
            },
            new InventoryItem()
            {
                ItemCount = 1,
                InternalInventoryItemType = Data.Enums.InternalInventoryItemType.LongGuns,
                ItemType = "/Lotus/Weapons/Tenno/Rifle/Rifle",
                ItemName = "MK1-Braton",
            }
            };
        }
    }
}