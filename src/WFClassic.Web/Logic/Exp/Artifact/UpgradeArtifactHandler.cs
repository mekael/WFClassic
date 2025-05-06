using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Admin.CheckOnline;
using WFClassic.Web.Logic.Credits.Add;
using WFClassic.Web.Logic.Credits.Get;

namespace WFClassic.Web.Logic.Exp.Artifact
{
    public class UpgradeArtifactHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<UpgradeArtifactHandler> _logger;
        private AddAccountTransactionHandler _addAccountTransactionHandler;
        private GetCreditsHandler _getCreditsHandler;

        public UpgradeArtifactHandler(ApplicationDbContext applicationDbContext, ILogger<UpgradeArtifactHandler> logger,
            AddAccountTransactionHandler addAccountTransactionHandler, GetCreditsHandler getCreditsHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _addAccountTransactionHandler = addAccountTransactionHandler;
            _getCreditsHandler = getCreditsHandler;
        }


        public UpgradeArtifactResult Handle(UpgradeArtifact upgradeArtifact)
        {
            UpgradeArtifactResult result = new UpgradeArtifactResult();


            var validationResults = new UpradeArtifactValidator().Validate(upgradeArtifact);

            if (!validationResults.IsValid)
            {
                _logger.LogError("UpgradeArtifactHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", upgradeArtifact.AccountId, upgradeArtifact.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.UpgradeArtifactResultStatus = UpgradeArtifactResultStatus.ValidationErrors;
                return result;
            }


            // get player and all items

            Player player = null;

            try
            {
                player = _applicationDbContext.Players.Include(i => i.InventoryItems)
                                                      .FirstOrDefault(i => i.ApplicationUserId == upgradeArtifact.AccountId);
            }
            catch (Exception ex)
            {
                _logger.LogError("UpgradeArtifactHandler => accountId {AccountID}  => Exception while querying for player {Ex}", upgradeArtifact.AccountId, ex);
                result.UpgradeArtifactResultStatus = UpgradeArtifactResultStatus.DatabaseErrors;
                return result;
            }


            GetCredits getCredits = new GetCredits()
            {
                AccountId = upgradeArtifact.AccountId,
                Nonce = upgradeArtifact.Nonce,
            };

            var getCreditsResult = _getCreditsHandler.Handle(getCredits);


            if (getCreditsResult.GetCreditsResultDetails.RegularCredits < upgradeArtifact.IncomingUpgradeArtifactRequest.Cost)
            {
                _logger.LogError("UpgradeArtifactHandler => accountId {AccountID} nonce {Nonce} => Not enough credits to proceed", upgradeArtifact.AccountId, upgradeArtifact.Nonce);
                result.UpgradeArtifactResultStatus = UpgradeArtifactResultStatus.ValidationErrors;
                return result;
            }




            // check to make sure that the item to upgrade is still at the appropriate level
            var itemToUpgrade = upgradeArtifact.IncomingUpgradeArtifactRequest.Upgrade;
            var inventoryItemToUpgrade = player.InventoryItems.FirstOrDefault(fod => fod.Id == Guid.Parse(upgradeArtifact.IncomingUpgradeArtifactRequest.Upgrade.ItemId.id));

            if (inventoryItemToUpgrade == null)
            {
                // we already got rid of it. 
                _logger.LogError("UpgradeArtifactHandler => accountId {AccountID} nonce {Nonce} => No matching artifact found", upgradeArtifact.AccountId, upgradeArtifact.Nonce);
                result.UpgradeArtifactResultStatus = UpgradeArtifactResultStatus.ValidationErrors;
                return result;
            }
            else if (itemToUpgrade.UpgradeFingerprint != itemToUpgrade.UpgradeFingerprint)
            {
                // already upgraded 
                _logger.LogError("UpgradeArtifactHandler => accountId {AccountID} nonce {Nonce} => Artifact has already been updated", upgradeArtifact.AccountId, upgradeArtifact.Nonce);
                result.UpgradeArtifactResultStatus = UpgradeArtifactResultStatus.ValidationErrors;
                return result;
            }

            // get the current bank account status
            // 
            int inventoryItemsToConsumeCounter = 0;
            var consumedItems = upgradeArtifact.IncomingUpgradeArtifactRequest.Consumed;

            // check to make sure that all of the consumed items exist and that they are at the appropriate level . 

            foreach (var consumedItem in consumedItems)
            {
                var itemToConsume = player.InventoryItems.FirstOrDefault(fod => fod.Id == Guid.Parse(consumedItem.ItemId.id));
                if (itemToConsume != null && itemToConsume.UpgradeFingerprint == consumedItem.UpgradeFingerprint)
                {
                    inventoryItemsToConsumeCounter++;
                }
            }

            if (consumedItems.Length != inventoryItemsToConsumeCounter)
            {
                // leave early 
                _logger.LogError("UpgradeArtifactHandler => accountId {AccountID} nonce {Nonce} => Some of the proposed artifacts have already been consumed.", upgradeArtifact.AccountId, upgradeArtifact.Nonce);
                result.UpgradeArtifactResultStatus = UpgradeArtifactResultStatus.ValidationErrors;
                return result;
            }


            inventoryItemToUpgrade.UpgradeFingerprint = itemToUpgrade.UpgradeFingerprint;
            _applicationDbContext.Entry(inventoryItemToUpgrade).State = EntityState.Modified;
            foreach (var consumedItem in consumedItems)
            {
                var itemToConsume = player.InventoryItems.FirstOrDefault(fod => fod.Id == Guid.Parse(consumedItem.ItemId.id));
                _applicationDbContext.Entry(itemToConsume).State = EntityState.Deleted;
            }


            try
            {
                _applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError("UpgradeArtifactHandler => accountId {AccountID}  => Exception while updating artifacts {Ex}", upgradeArtifact.AccountId, ex);
                result.UpgradeArtifactResultStatus = UpgradeArtifactResultStatus.DatabaseErrors;
                return result;
            }

            _addAccountTransactionHandler.Handle(new AddAccountTransaction()
            {
                AccountId = upgradeArtifact.AccountId,
                Amount = -1* upgradeArtifact.IncomingUpgradeArtifactRequest.Cost,
                BankAccountTransactionType = Data.Enums.BankAccountTransactionType.Debit,
                BankAccountType = Data.Enums.BankAccountType.StandardCredits,
                MemoCode = $"Upgraded {upgradeArtifact.IncomingUpgradeArtifactRequest.Upgrade.ItemId.id}"
            });
            result.UpgradeArtifactResultStatus = UpgradeArtifactResultStatus.Success;


            return result;
        }
    }
}
