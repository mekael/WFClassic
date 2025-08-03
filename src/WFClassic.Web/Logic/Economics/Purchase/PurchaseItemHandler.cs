using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Add;
using WFClassic.Web.Logic.Credits.Get;
using WFClassic.Web.Logic.Inventory.WarframeItemAddition;

namespace WFClassic.Web.Logic.Economics.Purchase
{
    public class PurchaseItemHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<PurchaseItemHandler> _logger;
        private AddAccountTransactionHandler _addAccountTransactionHandler;
        private GetCreditsHandler _getCreditsHandler;
        private readonly AddWarframeItemHandler _addWarframeItemHandler;

        public PurchaseItemHandler(ApplicationDbContext applicationDbContext, ILogger<PurchaseItemHandler> logger,
            AddAccountTransactionHandler addAccountTransactionHandler, GetCreditsHandler getCreditsHandler, AddWarframeItemHandler addWarframeItemHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _addAccountTransactionHandler = addAccountTransactionHandler;
            _getCreditsHandler = getCreditsHandler;
            _addWarframeItemHandler = addWarframeItemHandler;
        }

        public PurchaseItemResult Handle(PurchaseItem purchaseItem)
        {
            PurchaseItemResult result = new PurchaseItemResult();
            var validationResults = new PurchaseItemValidator().Validate(purchaseItem);

            if (!validationResults.IsValid)
            {
                _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", purchaseItem.AccountId, purchaseItem.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.PurchaseItemResultStatus = PurchaseItemResultStatus.ValidationErrors;
                return result;
            }

            Player player = null;
            MarketPackageDefinition marketPackageDefinition = null;
            try
            {
                _logger.LogInformation("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Starting Query for player and market item", purchaseItem.AccountId, purchaseItem.Nonce);
                player = _applicationDbContext.Players
                                                    .Include(i => i.PlayerPurchaseRecords)
                                                    .FirstOrDefault(w => w.ApplicationUserId == purchaseItem.AccountId);
                marketPackageDefinition = _applicationDbContext.MarketPackageDefinitions.AsNoTracking()
                                                                                         .AsNoTracking()
                                                                                        .FirstOrDefault(i => i.ItemType == purchaseItem.ProductName);
                _logger.LogInformation("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Query Complete for player and market item", purchaseItem.AccountId, purchaseItem.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", purchaseItem.AccountId, purchaseItem.Nonce, ex);
                result.PurchaseItemResultStatus = PurchaseItemResultStatus.DatabaseErrors;
                return result;
            }


            if (marketPackageDefinition == null)
            {
                _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Item definition does not exist {ProductName}", purchaseItem.AccountId, purchaseItem.Nonce, purchaseItem.ProductName);
                result.PurchaseItemResultStatus = PurchaseItemResultStatus.ValidationErrors;
                return result;       // can't find anything. bad request. bad bad request. 

            }



            _addWarframeItemHandler.Handle(new AddWarframeItem() { AccountId = purchaseItem.AccountId, ItemType = purchaseItem.ProductName, WarframeItemLocation = WarframeItemLocation.Market });





            var getCreditsResult = _getCreditsHandler.Handle(new GetCredits() { AccountId = purchaseItem.AccountId, Nonce = purchaseItem.Nonce });
            if (getCreditsResult.GetCreditsResultStatus != GetCreditsResultStatus.Success)
            {
                _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Unable to determine if user has enough credits {ProductName}", purchaseItem.AccountId, purchaseItem.Nonce, purchaseItem.ProductName);
                result.PurchaseItemResultStatus = PurchaseItemResultStatus.ValidationErrors;
                return result;
            }
            // check to see if the user has enough cash in that specific account
            else if (
                !(
                (marketPackageDefinition.CanBePurchasedWithPlat && purchaseItem.UsePremium==1 && getCreditsResult.GetCreditsResultDetails.PremiumCredits >= marketPackageDefinition.CostInPlat)
                ||
                (marketPackageDefinition.CanBePurchasedWithCredits && purchaseItem.UsePremium != 1 && getCreditsResult.GetCreditsResultDetails.RegularCredits >= marketPackageDefinition.CostInCredits)
                )
                )
            {
                _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => User does not have enough credits to purchase  {ProductName}", purchaseItem.AccountId, purchaseItem.Nonce, purchaseItem.ProductName);
                result.PurchaseItemResultStatus = PurchaseItemResultStatus.ValidationErrors;
                return result;
            }

 




            var currencyType = purchaseItem.UsePremium == 1 ? CurrencyType.Platinum : CurrencyType.StandardCredits;
            var amount = purchaseItem.UsePremium == 1 ? marketPackageDefinition.CostInPlat : marketPackageDefinition.CostInCredits;
            var addAccountTransactionResult = _addAccountTransactionHandler.Handle(new AddAccountTransaction() { AccountId = purchaseItem.AccountId, Amount = amount, BankAccountTransactionType = BankAccountTransactionType.Debit, BankAccountType = currencyType, MemoCode = "ItemSale" });
            if (addAccountTransactionResult.AddAccountTransactionResultStatus != AddAccountTransactionResultStatus.Success)
            {
                _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Issues while adding transaction amount to account ", purchaseItem.AccountId, purchaseItem.Nonce);
                result.PurchaseItemResultStatus = PurchaseItemResultStatus.ValidationErrors;
                return result;
            }



            try
            {
                _logger.LogInformation("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Updating Inventory", purchaseItem.AccountId, purchaseItem.Nonce);
                _applicationDbContext.SaveChanges();
                _logger.LogInformation("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Inventory Updated", purchaseItem.AccountId, purchaseItem.Nonce);
                result.PurchaseItemResultStatus = PurchaseItemResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Exception while updating inventory items : {Ex}", purchaseItem.AccountId, purchaseItem.Nonce, ex);
                result.PurchaseItemResultStatus = PurchaseItemResultStatus.DatabaseErrors;
                return result;
            }
            return result;
        }


      
    }
}