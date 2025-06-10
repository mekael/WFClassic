using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Add;
using WFClassic.Web.Logic.Credits.Get;

namespace WFClassic.Web.Logic.Economics.Slots
{
    public class PurchaseSlotsHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<PurchaseSlotsHandler> _logger;
        private AddAccountTransactionHandler _addAccountTransactionHandler;
        private GetCreditsHandler _getCreditsHandler;

        public PurchaseSlotsHandler(ApplicationDbContext applicationDbContext, ILogger<PurchaseSlotsHandler> logger,
            AddAccountTransactionHandler addAccountTransactionHandler, GetCreditsHandler getCreditsHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _addAccountTransactionHandler = addAccountTransactionHandler;
            _getCreditsHandler = getCreditsHandler;
        }

        public PurchaseSlotsResult Handle(PurchaseSlots purchaseSlots)
        {
            PurchaseSlotsResult result = new PurchaseSlotsResult();
            var validationResults = new PurchaseSlotsValidator().Validate(purchaseSlots);

            if (!validationResults.IsValid)
            {
                _logger.LogError("PurchaseSlotsHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", purchaseSlots.AccountId, purchaseSlots.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.PurchaseSlotsResultStatus = PurchaseSlotsResultStatus.ValidationErrors;
                return result;
            }


            // Determine the type of bin we're going to buy, and the multiplier, and the amount of plat

            InventoryBinType binType = purchaseSlots.IncomingPurchaseSlotsJsonObject.Contains("SuitBin") ? InventoryBinType.Suit : InventoryBinType.Weapon;
            int numberOfBins = binType == InventoryBinType.Suit ? 1 : 2;
            int platToCharge = binType == InventoryBinType.Suit ? 20 : 12;
            InventoryBin inventoryBin = null;

            try
            {
                _logger.LogInformation("PurchaseSlotsHandler => accountId {AccountID} nonce {Nonce} => Starting Query for bin", purchaseSlots.AccountId, purchaseSlots.Nonce);
                inventoryBin = _applicationDbContext.InventoryBins.Where(w => w.InventoryBinType == binType).FirstOrDefault();
                _logger.LogInformation("PurchaseSlotsHandler => accountId {AccountID} nonce {Nonce} => Query Complete for bin ", purchaseSlots.AccountId, purchaseSlots.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("PurchaseSlotsHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", purchaseSlots.AccountId, purchaseSlots.Nonce, ex);
                result.PurchaseSlotsResultStatus = PurchaseSlotsResultStatus.DatabaseErrors;
                return result;
            }

            if (inventoryBin == null)
            {
                // no inventory bin assigned.  this is actually problematic, but should be fixed except for very old accounts
                // cats
                _logger.LogError("PurchaseSlotsHandler => accountId {AccountID} nonce {Nonce} => User does not own suit", purchaseSlots.AccountId, purchaseSlots.Nonce);
                result.PurchaseSlotsResultStatus = PurchaseSlotsResultStatus.ValidationErrors;
                return result;
            }



            var getCreditsResult = _getCreditsHandler.Handle(new GetCredits() { AccountId = purchaseSlots.AccountId, Nonce = purchaseSlots.Nonce });
            if (getCreditsResult.GetCreditsResultStatus != GetCreditsResultStatus.Success)
            {
                // leave early as we can't figure out what the account balance is . 
                _logger.LogError("PurchaseSlotsHandler => accountId {AccountID} nonce {Nonce} => Exception while checking bank accounts ", purchaseSlots.AccountId, purchaseSlots.Nonce);
                result.PurchaseSlotsResultStatus = PurchaseSlotsResultStatus.DatabaseErrors;
                return result;
            }
            else if (getCreditsResult.GetCreditsResultDetails.PremiumCredits < platToCharge)
            {
                // don't have enough in our account
                _logger.LogInformation("PurchaseSlotsHandler => accountId {AccountID} nonce {Nonce} => User does not have necessary plat in account", purchaseSlots.AccountId, purchaseSlots.Nonce);
                result.PurchaseSlotsResultStatus = PurchaseSlotsResultStatus.ValidationErrors;
                return result;
            }


            inventoryBin.Extra += numberOfBins;
            inventoryBin.Slots += numberOfBins;

            try
            {
                _logger.LogInformation("PurchaseSlotsHandler => accountId {AccountID} nonce {Nonce} => Updating bin count", purchaseSlots.AccountId, purchaseSlots.Nonce);
                _applicationDbContext.Entry(inventoryBin).State = EntityState.Modified;
                _applicationDbContext.SaveChanges();
                _logger.LogInformation("PurchaseSlotsHandler => accountId {AccountID} nonce {Nonce} => successfully updated bin count", purchaseSlots.AccountId, purchaseSlots.Nonce);
                result.PurchaseSlotsResultStatus = PurchaseSlotsResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("PurchaseSlotsHandler => accountId {AccountID} nonce {Nonce} => Exception while updating bin : {Ex}", purchaseSlots.AccountId, purchaseSlots.Nonce, ex);
                result.PurchaseSlotsResultStatus = PurchaseSlotsResultStatus.DatabaseErrors;
                return result;
            }

            // add plat transaction. 
            // honestly we don't care if this succeed 
            _addAccountTransactionHandler.Handle(new AddAccountTransaction()
            {
                AccountId = purchaseSlots.AccountId,
                Amount =   platToCharge,
                BankAccountTransactionType = BankAccountTransactionType.Debit,
                BankAccountType = CurrencyType.Platinum,
                MemoCode = "Purchase revives"
            });
            return result;
        }

    }
}