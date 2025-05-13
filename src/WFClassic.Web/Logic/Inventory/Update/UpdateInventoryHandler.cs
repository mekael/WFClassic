using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Add;

namespace WFClassic.Web.Logic.Inventory.Update
{
    public class UpdateInventoryHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<UpdateInventoryHandler> _logger;
        private AddAccountTransactionHandler _addAccountTransactionHandler;

        public UpdateInventoryHandler(ApplicationDbContext applicationDbContext, ILogger<UpdateInventoryHandler> logger, AddAccountTransactionHandler addAccountTransactionHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _addAccountTransactionHandler = addAccountTransactionHandler;
        }

        public UpdateInventoryResult Handle(UpdateInventory updateInventory)
        {
            UpdateInventoryResult result = new UpdateInventoryResult();
            var validationResults = new UpdateInventoryValidator().Validate(updateInventory);

            if (!validationResults.IsValid)
            {
                _logger.LogError("UpdateInventoryHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", updateInventory.AccountId, updateInventory.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.UpdateInventoryResultStatus = UpdateInventoryResultStatus.ValidationErrors;
                return result;
            }

            Player player = null;

            try
            {
                _logger.LogInformation("UpdateInventoryHandler => accountId {AccountID} nonce {Nonce} => Starting Query for player", updateInventory.AccountId, updateInventory.Nonce);
                player = _applicationDbContext.Players
                                                    .Include(i => i.InventoryItems)
                                                    .Include(i => i.Missions)
                                                    .FirstOrDefault(w => w.ApplicationUserId == updateInventory.AccountId);
                _logger.LogInformation("UpdateInventoryHandler => accountId {AccountID} nonce {Nonce} => Query Complete for player ", updateInventory.AccountId, updateInventory.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("UpdateInventoryHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", updateInventory.AccountId, updateInventory.Nonce, ex);
                result.UpdateInventoryResultStatus = UpdateInventoryResultStatus.DatabaseErrors;
                return result;
            }

            try
            {
                _logger.LogInformation("UpdateInventoryHandler => accountId {AccountID} nonce {Nonce} => Updating playerXp", updateInventory.AccountId, updateInventory.Nonce);

                player.AdditionalPlayerXP += updateInventory.UpdateInventoryFromMissionObject.AdditionalPlayerXP;
                player.PlayerXP += updateInventory.UpdateInventoryFromMissionObject.PlayerXP;

                // update equipment
                _logger.LogInformation("UpdateInventoryHandler => accountId {AccountID} nonce {Nonce} => Updating equipment", updateInventory.AccountId, updateInventory.Nonce);

                List<JsonIncomingEquipmentItem> equipmentItems = new List<JsonIncomingEquipmentItem>()
                                                                                                     .Union(updateInventory.UpdateInventoryFromMissionObject.LongGuns)
                                                                                                     .Union(updateInventory.UpdateInventoryFromMissionObject.Pistols)
                                                                                                     .Union(updateInventory.UpdateInventoryFromMissionObject.Suits)
                                                                                                     .Union(updateInventory.UpdateInventoryFromMissionObject.Melee)
                                                                                                     .Union(updateInventory.UpdateInventoryFromMissionObject.Sentinels)
                                                                                                     .Union(updateInventory.UpdateInventoryFromMissionObject.SentinelWeapons)
                                                                                                     .ToList();

                foreach (var equipmentItem in equipmentItems.Where(w => !string.IsNullOrWhiteSpace(w.ItemId.id)))
                {
                    var item = player.InventoryItems.Find(f => f.Id == Guid.Parse(equipmentItem.ItemId.id));
                    item.XP += equipmentItem.XP;
                    _applicationDbContext.Entry(item).State = EntityState.Modified;
                }
                _logger.LogInformation("UpdateInventoryHandler => accountId {AccountID} nonce {Nonce} => Updating mods", updateInventory.AccountId, updateInventory.Nonce);

                foreach (var mod in updateInventory.UpdateInventoryFromMissionObject.Upgrades)
                {
                    _applicationDbContext.InventoryItems.Add(new InventoryItem()
                    {
                        ItemType = mod.ItemType,
                        UpgradeFingerprint = mod.UpgradeFingerprint,
                        PlayerId = player.Id,
                        InternalInventoryItemType = InternalInventoryItemType.Upgrades
                    });
                }
                _logger.LogInformation("UpdateInventoryHandler => accountId {AccountID} nonce {Nonce} => Updating misc/consumables/recipes", updateInventory.AccountId, updateInventory.Nonce);

                UpdateItemCountInventory(updateInventory.UpdateInventoryFromMissionObject.MiscItems, player.InventoryItems, InternalInventoryItemType.MiscItems, player.Id);
                UpdateItemCountInventory(updateInventory.UpdateInventoryFromMissionObject.Consumables, player.InventoryItems, InternalInventoryItemType.Consumables, player.Id);
                UpdateItemCountInventory(updateInventory.UpdateInventoryFromMissionObject.Recipes, player.InventoryItems, InternalInventoryItemType.Recipes, player.Id);

                if (updateInventory.UpdateInventoryFromMissionObject.MissionReport != null)
                {
                    MissionReport missionReport = CreateMissionReport(updateInventory.UpdateInventoryFromMissionObject.MissionReport, player.Id, updateInventory.Nonce);

                    _applicationDbContext.MissionReports.Add(missionReport);
                }

                _addAccountTransactionHandler.Handle(new AddAccountTransaction()
                {
                    AccountId = updateInventory.AccountId,
                    Amount = updateInventory.UpdateInventoryFromMissionObject.RegularCredits,
                    BankAccountTransactionType = BankAccountTransactionType.Credit,
                    BankAccountType = BankAccountType.StandardCredits,
                    MemoCode = "Mission"
                });

                // when we claim the daily reward we get a blank mission

                if (updateInventory.UpdateInventoryFromMissionObject.Missions != null)
                {
                    var existingMission = player.Missions.FirstOrDefault(f => f.Tag == updateInventory.UpdateInventoryFromMissionObject.Missions.Tag);

                    if (existingMission != null)
                    {
                        existingMission.Completes = updateInventory.UpdateInventoryFromMissionObject.Missions.Completes;
                        existingMission.BestRatings = updateInventory.UpdateInventoryFromMissionObject.Missions.BestRating;
                        _applicationDbContext.Entry(existingMission).State = EntityState.Modified;
                    }
                    else
                    {
                        Mission mission = new Mission()
                        {
                            PlayerId = player.Id,
                            Tag = updateInventory.UpdateInventoryFromMissionObject.Missions.Tag,
                            Completes = updateInventory.UpdateInventoryFromMissionObject.Missions.Completes,
                            BestRatings = updateInventory.UpdateInventoryFromMissionObject.Missions.BestRating
                        };
                        _applicationDbContext.Missions.Add(mission);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("UpdateInventoryHandler => accountId {AccountID} nonce {Nonce} => Exception mapping updates : {Ex}", updateInventory.AccountId, updateInventory.Nonce, ex);
                result.UpdateInventoryResultStatus = UpdateInventoryResultStatus.MappingFailure;
                return result;
            }

            //TODO addChallenges(inventory, ChallengeProgress);

            try
            {
                _logger.LogInformation("UpdateInventoryHandler => accountId {AccountID} nonce {Nonce} => Updating player object", updateInventory.AccountId, updateInventory.Nonce);
                _applicationDbContext.Entry(player).State = EntityState.Modified;
                _applicationDbContext.SaveChanges();
                _logger.LogInformation("UpdateInventoryHandler => accountId {AccountID} nonce {Nonce} => update successful", updateInventory.AccountId, updateInventory.Nonce);
                result.UpdateInventoryResultStatus = UpdateInventoryResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("UpdateInventoryHandler => accountId {AccountID} nonce {Nonce} => Exception while updating player object : {Ex}", updateInventory.AccountId, updateInventory.Nonce, ex);
                result.UpdateInventoryResultStatus = UpdateInventoryResultStatus.DatabaseErrors;
                return result;
            }
            return result;
        }

        private void UpdateItemCountInventory(List<ItemCountPair> incomingEquipmentItems, List<InventoryItem> existingItems, InternalInventoryItemType internalInventoryItemType, Guid playerId)
        {
            foreach (var equipmentItem in incomingEquipmentItems)
            {
                var item = existingItems.FirstOrDefault(f => f.ItemType == equipmentItem.ItemType);

                if (item != null)
                {
                    item.ItemCount += equipmentItem.ItemCount;
                    _applicationDbContext.Entry(item).State = EntityState.Modified;
                }
                else
                {
                    InventoryItem inventoryItem = new InventoryItem()
                    {
                        PlayerId = playerId,
                        ItemCount = equipmentItem.ItemCount,
                        ItemType = equipmentItem.ItemType,
                        InternalInventoryItemType = internalInventoryItemType
                    };
                    _applicationDbContext.InventoryItems.Add(inventoryItem);
                }
            }
        }

        private MissionReport CreateMissionReport(IncomingMissionreport incomingMissionReport, Guid playerId, long nonce)
        {
            MissionReport report = new MissionReport()
            {
                PlayerId = playerId,
                Nonce = nonce
            };

            try
            {
                report = new MissionReport()
                {
                    PlayerId = playerId,
                    Nonce = nonce,
                    FullReport = incomingMissionReport.PlayerReport.FullReport,
                    HostId = incomingMissionReport.HostId,
                    MissionName = incomingMissionReport.MishName,
                    MissionStartTime = incomingMissionReport.MishStartTime,
                    ReporterId = incomingMissionReport.PlayerReport.ReporterId,
                    PlayerReports = incomingMissionReport.PlayerReport.PlayerMishInfos.Select(report => new PlayerReport()
                    {
                        AssociatedAccountId = report.Pid,
                        CredtBonus = report.CredBonus,
                        Credits = report.Creds,
                        MeleeXpBonus = report.MeleeXpBonus,
                        PistolXpBonus = report.PistolXpBonus,
                        Rating = report.Rating,
                        RifleXpBonus = report.RfileXpBonus,
                        SentinelWeaponXpBonus = report.SentnlWepXpBonus,
                        SentinelXPBonus = report.SentnlXPBonus,
                        SuitXpBonus = report.SuitXpBonus,
                        Xp = report.Xp,
                        XpBonus = report.XpBonus,
                        Upgrades = report.Upgrades != null ? string.Join(";", report.Upgrades) : ""
                    }).ToList()
                };
            }
            catch (Exception ex)
            {
                _logger.LogError("UpdateInventoryHandler => playerId {playerId} nonce {Nonce} => Exception while creating missionreport : {Ex}", playerId, nonce, ex);
            }
            return report;
        }
    }
}