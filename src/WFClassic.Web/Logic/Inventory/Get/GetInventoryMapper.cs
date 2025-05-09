

using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Get;
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

        public static GetInventoryResultDetails Map(Player player, List<InventoryItemAttachment> attachments)
        {

            List<GetInventoryResultJsonUpgradeItem> JsonUpgradeItems = new List<GetInventoryResultJsonUpgradeItem>();


            foreach (var upgrade in player.InventoryItems.Where(w => w.InternalInventoryItemType == InternalInventoryItemType.Upgrades))
            {

                InventoryItemAttachment attachment = attachments.FirstOrDefault(w => w.AttachedInventoryItemId == upgrade.Id);

                JsonUpgradeItems.Add(new GetInventoryResultJsonUpgradeItem()
                {
                    ItemId = new MongoId(upgrade.Id),
                    ItemType = upgrade.ItemType,
                    UpgradeFingerPrint = upgrade.UpgradeFingerprint,
                    ParentId = attachment !=null ? new MongoId(attachment.ParentInventoryItemId) : null,
                    Slot = attachment != null ? attachment.Slot: null
                });
            }


            var whateve = player.InventoryItems.Where(w => w.InternalInventoryItemType == InternalInventoryItemType.Upgrades).Select(
                s => new GetInventoryResultJsonUpgradeItem() { ItemId = new MongoId(s.Id), ItemType = s.ItemType, UpgradeFingerPrint = s.UpgradeFingerprint }
                ); ;

            return new GetInventoryResultDetails()

            {
                AdditionalPlayerXP = player.AdditionalPlayerXP,
                CompletedAlerts = new List<string>(),
                DeathMarks = new List<string>() {"Stalker" },
                Founder = 2,
                InvalidBin = GetBin(InventoryBinType.Invalid, player.InventoryBins),
                MiscBin = GetBin(InventoryBinType.Invalid, player.InventoryBins),
                SuitBin = GetBin(InventoryBinType.Invalid, player.InventoryBins),
                SentinelBin = GetBin(InventoryBinType.Invalid, player.InventoryBins),
                WeaponBin = GetBin(InventoryBinType.Invalid, player.InventoryBins),
                Cards = GetEquipmentByType(InternalInventoryItemType.Cards, player.InventoryItems),
                LongGuns = GetEquipmentByType(InternalInventoryItemType.LongGuns, player.InventoryItems),
                Pistols = GetEquipmentByType(InternalInventoryItemType.Pistols, player.InventoryItems),
                Melee = GetEquipmentByType(InternalInventoryItemType.Melee, player.InventoryItems),
                Suits = GetEquipmentByType(InternalInventoryItemType.Suits, player.InventoryItems),
                Sentinels = GetEquipmentByType(InternalInventoryItemType.Sentinels, player.InventoryItems),
                SentinelWeapons = GetEquipmentByType(InternalInventoryItemType.SentinelWeapons, player.InventoryItems),
                Consumables = GetJsonTypeCount(InternalInventoryItemType.Consumables, player.InventoryItems),
                MiscItems = GetJsonTypeCount(InternalInventoryItemType.MiscItems, player.InventoryItems),
                Recipes = GetJsonTypeCount(InternalInventoryItemType.Recipes, player.InventoryItems),
                //Components = GetJsonTypeCount(InternalInventoryItemType.MiscItems, player.InventoryItems),

                Missions = player.Missions == null ? new List<GetInventoryResultJsonMission>() : player.Missions.Select(s => new GetInventoryResultJsonMission() { BestRating = s.BestRatings, Completes = s.Completes, Tag = s.Tag }).ToList(),
                PlayerLevel = player.PlayerLevel,
                PlayerXP = player.PlayerXP,
                Rating = player.Rating,
                RewardSeed = 102938102938,
                XPInfo = player.InventoryItems.Where(w => xpItems.Contains(w.InternalInventoryItemType)).Select(s => new GetInventoryResultJsonXpInfoItem() { ItemType = s.ItemType, XP = s.XP }).ToList(),
                ReceivedStartingGear = player.ReceivedStartingGear,
                SubscribedToEmails = Convert.ToInt32(player.SubscribedToEmails),
                TrainingDate = new MongoDate(player.TrainingDate),
                PremiumCredits = player.BankAccounts.Where(w => w.BankAccountType == BankAccountType.Platinum).Select(s => s.CurrentBalance).Sum(),
                RegularCredits = player.BankAccounts.Where(w => w.BankAccountType == BankAccountType.StandardCredits).Select(s => s.CurrentBalance).Sum(),
                TauntHistory = player.TauntHistoryItems.Select(s => new GetInventoryResultJsonTauntHistoryItem() { node = s.Node }).ToList(),
                Upgrades = JsonUpgradeItems
            };

        }


        static GetInventoryResultJsonInventoryBin GetBin(InventoryBinType inventoryBinType, List<InventoryBin> inventoryBins)
        {
            InventoryBin inventoryBin = inventoryBins.FirstOrDefault(fod => fod.InventoryBinType == inventoryBinType);
            return inventoryBin == null ? new GetInventoryResultJsonInventoryBin() { Slots = 2 } : new GetInventoryResultJsonInventoryBin() { Extra = inventoryBin.Extra, Slots = inventoryBin.Slots };
        }


        static List<GetInventoryResultJsonTypeCount> GetJsonTypeCount(InternalInventoryItemType internalInventoryItemType, List<InventoryItem> inventoryItems)
        {
            return inventoryItems.Where(w => w.InternalInventoryItemType == internalInventoryItemType).Select(s => new GetInventoryResultJsonTypeCount() { ItemType = s.ItemType, ItemCount = s.ItemCount }).ToList();

        }

            static List<GetInventoryResultJsonEquipmentItem> GetEquipmentByType(InternalInventoryItemType internalInventoryItemType, List<InventoryItem> inventoryItems)
        {

            return inventoryItems.Where(w => w.InternalInventoryItemType == internalInventoryItemType).ToList()
                .Select(s => new GetInventoryResultJsonEquipmentItem()
                {
                    ExtraCapacity = s.ExtraCapacity,
                    ExtraRemaining = s.ExtraRemaining,
                    ItemId = new MongoId(s.Id),
                    ItemType = s.ItemType,
                    UnlockLevel = s.UnlockLevel,
                    UpgradeVer = s.UpgradeVer,
                    XP = s.XP
                }).ToList();
        }

    }
}