

using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Inventory.Get
{
    public static class GetInventoryMapper
    {
        static List<InternalInventoryItemType> xpItems = new List<InternalInventoryItemType>() { InternalInventoryItemType.Sentinels, 
                                                                                           InternalInventoryItemType.SentinelWeapons,
                                                                                           InternalInventoryItemType.Suits,
                                                                                           InternalInventoryItemType.LongGuns,
                                                                                           InternalInventoryItemType.Pistols,
                                                                                           InternalInventoryItemType.Melee
         };

        public static GetInventoryResultDetails Map(Player player)
        {
            return new GetInventoryResultDetails()

            {
                AdditionalPlayerXP = player.AdditionalPlayerXP,
                CompletedAlerts = new List<string>(),
                DeathMarks = new List<string>(),
                Founder = "Master",
                InvalidBin = GetBin(InventoryBinType.Invalid, player.InventoryBins),
                MiscBin = GetBin(InventoryBinType.Invalid, player.InventoryBins),
                SuitBin = GetBin(InventoryBinType.Invalid, player.InventoryBins),
                SentinelBin = GetBin(InventoryBinType.Invalid, player.InventoryBins),
                WeaponBin = GetBin(InventoryBinType.Invalid, player.InventoryBins),

                LongGuns = GetEquipmentByType(InternalInventoryItemType.LongGuns, player.InventoryItems),
                Pistols = GetEquipmentByType(InternalInventoryItemType.Pistols, player.InventoryItems),
                Melee = GetEquipmentByType(InternalInventoryItemType.Melee, player.InventoryItems),
                Suits = GetEquipmentByType(InternalInventoryItemType.Suits, player.InventoryItems),
                Sentinels = GetEquipmentByType(InternalInventoryItemType.Sentinels, player.InventoryItems),
                SentinelWeapons = GetEquipmentByType(InternalInventoryItemType.SentinelWeapons, player.InventoryItems),
                Missions = player.Missions == null ? new List<JsonMission>() : player.Missions.Select(s => new JsonMission() { BestRating = s.BestRatings, Completes = s.Completes, Tag = s.Tag }).ToList(),
                PlayerLevel = player.PlayerLevel,
                PlayerXP = player.PlayerXP,
                Rating = player.Rating,
                RewardSeed = 102938102938,
                XPInfo = player.InventoryItems.Where(w => xpItems.Contains(w.InternalInventoryItemType)).Select(s => new JsonXpInfoItem() { ItemType = s.ItemType, XP = s.XP }).ToList(),
                ReceivedStartingGear = player.ReceivedStartingGear,
                SubscribedToEmails = Convert.ToInt32(player.SubscribedToEmails),
                TrainingDate    =  new MongoDate(player.TrainingDate),
                PremiumCredits=0,
                RegularCredits=0


            };

        }


        static JsonInventoryBin GetBin(InventoryBinType inventoryBinType, List<InventoryBin> inventoryBins)
        {
            InventoryBin inventoryBin = inventoryBins.FirstOrDefault(fod => fod.InventoryBinType == inventoryBinType);
            return inventoryBin == null ? new JsonInventoryBin() {   Slots=2} : new JsonInventoryBin() { Extra = inventoryBin.Extra, Slots = inventoryBin.Slots };
        }


        static List<JsonEquipmentItem> GetEquipmentByType(InternalInventoryItemType internalInventoryItemType, List<InventoryItem> inventoryItems)
        {

            return inventoryItems.Where(w => w.InternalInventoryItemType == internalInventoryItemType).ToList()
                .Select(s => new JsonEquipmentItem()
                {
                    ExtraCapacity = s.ExtraCapacity,
                    ExtraRemaining = s.ExtraRemaining,
                    ItemId = new MongoId(s.Id),
                    ItemType = s.ItemType,
                    UnlockLevel = s.UnlockLevel,
                    UpgradeVer = 101,
                    XP = s.XP 
                }).ToList();
        }

    }
}