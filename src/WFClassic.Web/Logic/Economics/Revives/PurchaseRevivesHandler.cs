using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Add;
using WFClassic.Web.Logic.Credits.Get;

namespace WFClassic.Web.Logic.Economics.Revives
{
    public class PurchaseRevivesHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<PurchaseRevivesHandler> _logger;
        private AddAccountTransactionHandler _addAccountTransactionHandler;
        private GetCreditsHandler _getCreditsHandler;

        public PurchaseRevivesHandler(ApplicationDbContext applicationDbContext, ILogger<PurchaseRevivesHandler> logger,
            AddAccountTransactionHandler addAccountTransactionHandler, GetCreditsHandler getCreditsHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _addAccountTransactionHandler = addAccountTransactionHandler;
            _getCreditsHandler = getCreditsHandler;
        }

        public PurchaseRevivesResult Handle(PurchaseRevives purchaseRevives)
        {
            PurchaseRevivesResult result = new PurchaseRevivesResult();
            var validationResults = new PurchaseRevivesValidator().Validate(purchaseRevives);

            if (!validationResults.IsValid)
            {
                _logger.LogError("PurchaseRevivesHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", purchaseRevives.AccountId, purchaseRevives.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.PurchaseRevivesResultStatus = PurchaseRevivesResultStatus.ValidationErrors;
                return result;
            }

            InventoryItem suit = null;
            try
            {
                _logger.LogInformation("PurchaseRevivesHandler => accountId {AccountID} nonce {Nonce} => Starting Query for suit", purchaseRevives.AccountId, purchaseRevives.Nonce);

                suit = _applicationDbContext.InventoryItems.FirstOrDefault(fod => fod.Player.ApplicationUserId == purchaseRevives.AccountId && fod.Id == purchaseRevives.IncomingRefillRevivesJsonObject.SuitId.id);

                _logger.LogInformation("PurchaseRevivesHandler => accountId {AccountID} nonce {Nonce} => Query Complete for suit ", purchaseRevives.AccountId, purchaseRevives.Nonce);

            }
            catch (Exception ex)
            {
                _logger.LogError("PurchaseRevivesHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", purchaseRevives.AccountId, purchaseRevives.Nonce, ex);
                result.PurchaseRevivesResultStatus = PurchaseRevivesResultStatus.DatabaseErrors;
                return result;
            }

            if (suit == null)
            {
                //either doesnt own suit, or suit doesn't exist
                _logger.LogError("PurchaseRevivesHandler => accountId {AccountID} nonce {Nonce} => User does not own suit", purchaseRevives.AccountId, purchaseRevives.Nonce);
                result.PurchaseRevivesResultStatus = PurchaseRevivesResultStatus.ValidationErrors;
                return result;
            }
            else if (suit.ExtraRemaining == 4)
            {
                // we are already full up 
                _logger.LogInformation("PurchaseRevivesHandler => accountId {AccountID} nonce {Nonce} => User owns suit, but suit has max revives already", purchaseRevives.AccountId, purchaseRevives.Nonce);
                result.PurchaseRevivesResultStatus = PurchaseRevivesResultStatus.ValidationErrors;
                return result;
            }

            int revivesToPurchase = 4 - suit.ExtraRemaining;

            var getCreditsResult = _getCreditsHandler.Handle(new GetCredits() { AccountId = purchaseRevives.AccountId, Nonce = purchaseRevives.Nonce });
            if (getCreditsResult.GetCreditsResultStatus != GetCreditsResultStatus.Success)
            {
                // leave early as we can't figure out what the account balance is . 
                _logger.LogError("PurchaseRevivesHandler => accountId {AccountID} nonce {Nonce} => Exception while checking bank accounts ", purchaseRevives.AccountId, purchaseRevives.Nonce);
                result.PurchaseRevivesResultStatus = PurchaseRevivesResultStatus.DatabaseErrors;
                return result;
            }
            else if (getCreditsResult.GetCreditsResultDetails.PremiumCredits < revivesToPurchase * 3)
            {
                // don't have enough in our account
                _logger.LogInformation("PurchaseRevivesHandler => accountId {AccountID} nonce {Nonce} => User does not have necessary plat in account", purchaseRevives.AccountId, purchaseRevives.Nonce);
                result.PurchaseRevivesResultStatus = PurchaseRevivesResultStatus.ValidationErrors;
                return result;
            }
            suit.ExtraRemaining = 4;

            try
            {
                _logger.LogInformation("PurchaseRevivesHandler => accountId {AccountID} nonce {Nonce} => Updating suit revives", purchaseRevives.AccountId, purchaseRevives.Nonce);
                _applicationDbContext.Entry(suit).State = EntityState.Modified;
                _applicationDbContext.SaveChanges();
                _logger.LogInformation("PurchaseRevivesHandler => accountId {AccountID} nonce {Nonce} => successfully updated suit revives", purchaseRevives.AccountId, purchaseRevives.Nonce);
                result.PurchaseRevivesResultStatus = PurchaseRevivesResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("PurchaseRevivesHandler => accountId {AccountID} nonce {Nonce} => Exception while updating suit : {Ex}", purchaseRevives.AccountId, purchaseRevives.Nonce, ex);
                result.PurchaseRevivesResultStatus = PurchaseRevivesResultStatus.DatabaseErrors;
                return result;
            }

            // add plat transaction. 
            // honestly we don't care if this succeed 
            _addAccountTransactionHandler.Handle(new AddAccountTransaction() { AccountId = purchaseRevives.AccountId, 
                                                                                Amount = -3 * revivesToPurchase, 
                                                                                BankAccountTransactionType = BankAccountTransactionType.Debit, 
                                                                                BankAccountType = CurrencyType.Platinum, 
                                                                                MemoCode = "Purchase revives" });
            return result;
        }

    }
}