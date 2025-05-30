using System.Net.Mail;
using System.Numerics;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Inventory.Get
{
    public static class GetInventoryMapper
    {
        private static List<InternalInventoryItemType> xpItems = new List<InternalInventoryItemType>() { InternalInventoryItemType.Sentinels,
                                                                                           InternalInventoryItemType.SentinelWeapons,
                                                                                           InternalInventoryItemType.Suits,
                                                                                           InternalInventoryItemType.LongGuns,
                                                                                           InternalInventoryItemType.Pistols,
                                                                                           InternalInventoryItemType.Melee
         };

        public static GetInventoryResultDetails Map(Player player, List<InventoryItemAttachment> attachments)
        {
            List<GetInventoryResultJsonUpgradeItem> JsonUpgradeItems = new List<GetInventoryResultJsonUpgradeItem>();

            foreach (var upgrade in player.InventoryItems.Where(w => w.InternalInventoryItemType == InternalInventoryItemType.Upgrades  ))
            {
                InventoryItemAttachment attachment = attachments.FirstOrDefault(w => w.AttachedInventoryItemId == upgrade.Id);

                JsonUpgradeItems.Add(new GetInventoryResultJsonUpgradeItem()
                {
                    ItemId = new MongoId(upgrade.Id),
                    ItemType = upgrade.ItemType,
                    UpgradeFingerPrint = upgrade.UpgradeFingerprint,
                    ParentId = attachment != null ? new MongoId(attachment.ParentInventoryItemId) : null,
                    Slot = attachment != null ? attachment.Slot : null
                });
            }

 
       
            return new GetInventoryResultDetails()

            {
                AdditionalPlayerXP = player.AdditionalPlayerXP,
                CompletedAlerts = new List<string>(),
                DeathMarks = new List<string>() { },
                Founder = 2,
                InvalidBin = GetBin(InventoryBinType.Invalid, player.InventoryBins),
                MiscBin = GetBin(InventoryBinType.Misc, player.InventoryBins),
                SuitBin = GetBin(InventoryBinType.Suit, player.InventoryBins),
                SentinelBin = GetBin(InventoryBinType.Sentinel, player.InventoryBins),
                WeaponBin = GetBin(InventoryBinType.Weapon, player.InventoryBins),
                Cards = GetUpgrade(player.InventoryItems, attachments, InternalInventoryItemType.Cards),
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
                FlavourItems = player.InventoryItems.Where(w=>w.InternalInventoryItemType == InternalInventoryItemType.FlavourItems).Select(s=> new GetInventoryResultJsonFlavourItem() { ItemType = s.ItemType}).ToList(),
                ActiveAvatarImageType = player.ActiveAvatarImageType,
                Missions = player.Missions == null ? new List<GetInventoryResultJsonMission>() : player.Missions.Select(s => new GetInventoryResultJsonMission() { BestRating = s.BestRatings, Completes = s.Completes, Tag = s.Tag }).ToList(),
                PlayerLevel = player.PlayerLevel,
                PlayerXP = player.PlayerXP,
                Rating = player.Rating,
                RewardSeed = new Random().NextInt64(),
                XPInfo = player.InventoryItems.Where(w => xpItems.Contains(w.InternalInventoryItemType)).Select(s => new GetInventoryResultJsonXpInfoItem() { ItemType = s.ItemType, XP = s.XP }).ToList(),
                ReceivedStartingGear = player.ReceivedStartingGear,
                SubscribedToEmails = Convert.ToInt32(player.SubscribedToEmails),
                TrainingDate = new MongoDate(player.TrainingDate),
                PremiumCredits = player.BankAccounts.Where(w => w.BankAccountType == CurrencyType.Platinum).Select(s => s.CurrentBalance).Sum(),
                RegularCredits = player.BankAccounts.Where(w => w.BankAccountType == CurrencyType.StandardCredits).Select(s => s.CurrentBalance).Sum(),
                TauntHistory = player.TauntHistoryItems.Select(s => new GetInventoryResultJsonTauntHistoryItem() { node = s.Node }).ToList(),
                Upgrades = GetUpgrade(player.InventoryItems, attachments, InternalInventoryItemType.Upgrades),                
            };
        }



        private static GetInventoryResultJsonInventoryBin GetBin(InventoryBinType inventoryBinType, List<InventoryBin> inventoryBins)
        {
            InventoryBin inventoryBin = inventoryBins.FirstOrDefault(fod => fod.InventoryBinType == inventoryBinType);
            return inventoryBin == null ? new GetInventoryResultJsonInventoryBin() { Slots = 2, Extra = 2 } : new GetInventoryResultJsonInventoryBin() { Extra = inventoryBin.Extra, Slots = inventoryBin.Slots };
        }

        private static List<GetInventoryResultJsonTypeCount> GetJsonTypeCount(InternalInventoryItemType internalInventoryItemType, List<InventoryItem> inventoryItems)
        {
            return inventoryItems.Where(w => w.InternalInventoryItemType == internalInventoryItemType).Select(s => new GetInventoryResultJsonTypeCount() { ItemType = s.ItemType, ItemCount = s.ItemCount }).ToList();
        }

        private static List<GetInventoryResultJsonEquipmentItem> GetEquipmentByType(InternalInventoryItemType internalInventoryItemType, List<InventoryItem> inventoryItems)
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

        private static List<GetInventoryResultJsonUpgradeItem> GetUpgrade(List<InventoryItem> inventoryItems, List<InventoryItemAttachment> attachments, InternalInventoryItemType internalInventoryItemType)
        {
            List<GetInventoryResultJsonUpgradeItem> JsonUpgradeItems = new List<GetInventoryResultJsonUpgradeItem>();

            foreach (var upgrade in inventoryItems.Where(w => w.InternalInventoryItemType == internalInventoryItemType))
            {
                InventoryItemAttachment attachment = attachments.FirstOrDefault(w => w.AttachedInventoryItemId == upgrade.Id);

                JsonUpgradeItems.Add(new GetInventoryResultJsonUpgradeItem()
                {
                    ItemId = new MongoId(upgrade.Id),
                    ItemType = upgrade.ItemType,
                    UpgradeFingerPrint = upgrade.UpgradeFingerprint,
                    ParentId = attachment != null ? new MongoId(attachment.ParentInventoryItemId) : null,
                    Slot = attachment != null ? attachment.Slot : null
                });
            }

            return JsonUpgradeItems;
        }
    }
}