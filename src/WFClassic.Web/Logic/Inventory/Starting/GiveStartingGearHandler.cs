using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Inventory.Starting
{
    public class GiveStartingGearHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<GiveStartingGearHandler> _logger;

        public GiveStartingGearHandler(ApplicationDbContext applicationDbContext, ILogger<GiveStartingGearHandler> logger
            )
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public GiveStartingGearResult Handle(GiveStartingGear giveStartingGear)
        {
            GiveStartingGearResult result = new GiveStartingGearResult();
            var validationResults = new GiveStartingGearValidator().Validate(giveStartingGear);

            if (!validationResults.IsValid)
            {
                _logger.LogError("GiveStartingGearHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", giveStartingGear.AccountId, giveStartingGear.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.Status = GiveStartingGearResultStatus.ValidationErrors;
                return result;
            }

            Player player = null;

            try
            {
                _logger.LogInformation("GiveStartingGearHandler => accountId {AccountID} nonce {Nonce} => Starting Query for player", giveStartingGear.AccountId, giveStartingGear.Nonce);
                player = _applicationDbContext.Players.Include(i => i.InventoryItems)
                                                      .Include(i=> i.InventoryBins)
                                                      .FirstOrDefault(w => w.ApplicationUserId == giveStartingGear.AccountId);
                _logger.LogInformation("GiveStartingGearHandler => accountId {AccountID} nonce {Nonce} => Query Complete for player ", giveStartingGear.AccountId, giveStartingGear.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GiveStartingGearHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", giveStartingGear.AccountId, giveStartingGear.Nonce, ex);
            }

            if (player.ReceivedStartingGear || player.InventoryItems.Any(a => a.ItemType.Contains("Powersuits")))
            {
                _logger.LogInformation("GiveStartingGearHandler => accountId {AccountID} nonce {Nonce} => User already has starting gear  ", giveStartingGear.AccountId, giveStartingGear.Nonce);
                result.Status = GiveStartingGearResultStatus.AlreadyReceivedStartingGear;
                return result;
            }

            string warframeName = giveStartingGear.WarframeName.Split("/").Last();

            player.InventoryItems.Add(new InventoryItem()
            {
                ItemCount = 1,
                InternalInventoryItemType = Data.Enums.InternalInventoryItemType.Suits,
                ItemType = giveStartingGear.WarframeName,
                ItemName = giveStartingGear.WarframeName.Split("/").Last(),
                UpgradeVer =101,
                ExtraCapacity= 4,
                ExtraRemaining =4
                
            });

            player.InventoryItems.AddRange(StartingGearDefinitions.GetStartingCards(warframeName));
            player.InventoryItems.AddRange(StartingGearDefinitions.GetStartingWeapons());

            player.InventoryBins.Add(new InventoryBin() { InventoryBinType = InventoryBinType.Suit, Slots = 2 });
            player.InventoryBins.Add(new InventoryBin() { InventoryBinType = InventoryBinType.Weapon, Slots = 8 });
            player.InventoryBins.Add(new InventoryBin() { InventoryBinType = InventoryBinType.Sentinel, Slots = 8 });

            player.ReceivedStartingGear = true;

            try
            {
                _logger.LogInformation("GiveStartingGearHandler => accountId {AccountID} nonce {Nonce} => Updating player object", giveStartingGear.AccountId, giveStartingGear.Nonce);
                _applicationDbContext.Entry(player).State = EntityState.Modified;
                _applicationDbContext.SaveChanges();
                _logger.LogInformation("GiveStartingGearHandler => accountId {AccountID} nonce {Nonce} => updated player object ", giveStartingGear.AccountId, giveStartingGear.Nonce);
                result.Status = GiveStartingGearResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("GiveStartingGearHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", giveStartingGear.AccountId, giveStartingGear.Nonce, ex);
                result.Status = GiveStartingGearResultStatus.DatabaseErrors;
            }
            return result;
        }
    }
}