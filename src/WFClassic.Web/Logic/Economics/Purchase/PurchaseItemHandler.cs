using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Add;
using WFClassic.Web.Logic.Credits.Get;

namespace WFClassic.Web.Logic.Economics.Purchase
{
    public class PurchaseItemHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<PurchaseItemHandler> _logger;
        private AddAccountTransactionHandler _addAccountTransactionHandler;
        private GetCreditsHandler _getCreditsHandler;

        public PurchaseItemHandler(ApplicationDbContext applicationDbContext, ILogger<PurchaseItemHandler> logger,
            AddAccountTransactionHandler addAccountTransactionHandler, GetCreditsHandler getCreditsHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _addAccountTransactionHandler = addAccountTransactionHandler;
            _getCreditsHandler = getCreditsHandler;
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
                _logger.LogInformation("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Starting Query for player", purchaseItem.AccountId, purchaseItem.Nonce);
                player = _applicationDbContext.Players
                                                    .Include(i => i.InventoryItems)
                                                    .Include(i => i.PlayerPurchaseRecords)
                                                    .Include(i => i.InventoryBins)
                                                    .FirstOrDefault(w => w.ApplicationUserId == purchaseItem.AccountId);
                marketPackageDefinition = _applicationDbContext.MarketPackageDefinitions.Include(i => i.MarketPackageItemDefinitions)
                                                                                        .FirstOrDefault(i => i.ItemType == purchaseItem.ProductName);
                _logger.LogInformation("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Query Complete for player ", purchaseItem.AccountId, purchaseItem.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", purchaseItem.AccountId, purchaseItem.Nonce, ex);
                result.PurchaseItemResultStatus = PurchaseItemResultStatus.DatabaseErrors;
                return result;
            }


            if (marketPackageDefinition == null)
            {
                // can't find anything. bad request. bad bad request. 

            }
                        // check to see if the player has already purchased the item and if it is a one time purchase or not


            if (player.PlayerPurchaseRecords.Any(a => a.MarketPackageDefinitionId == marketPackageDefinition.Id) && !marketPackageDefinition.CanBePurchasedMultipleTimes)
            {

            }

            var getCreditsResult = _getCreditsHandler.Handle(new GetCredits() { AccountId = purchaseItem.AccountId, Nonce = purchaseItem.Nonce });
            if (getCreditsResult.GetCreditsResultStatus != GetCreditsResultStatus.Success)
            {
                // server issues
            }
            // check to see if the user has enough cash in that specific account
 

            else if (
                !(
                (marketPackageDefinition.CanBePurchasedWithPlat && purchaseItem.UsePremium && getCreditsResult.GetCreditsResultDetails.PremiumCredits >= marketPackageDefinition.CostInPlat)
                ||
                (marketPackageDefinition.CanBePurchasedWithCredits && !purchaseItem.UsePremium && getCreditsResult.GetCreditsResultDetails.RegularCredits >= marketPackageDefinition.CostInCredits)
                )
                )
            {
                // return bad request
            }

            // this is essentially UpdateInventory, but inventory is provided server side rather than client
            // the call is coming from inside the house. 

            try {

                foreach (var packageItem in marketPackageDefinition.MarketPackageItemDefinitions)
                {
                    if (packageItem.IsUniqueItem && packageItem.CanBeAddedRepeatedly) {
                        // weapons, suits, etc
                        _applicationDbContext.InventoryItems.Add(CreateNewInventoryItemInstance(packageItem, player.Id));
                    }
                    else if (packageItem.IsUniqueItem && !packageItem.CanBeAddedRepeatedly)
                    {
                        // keys and such, i think. 
 
                        InventoryItem inventoryItem = player.InventoryItems.FirstOrDefault(fod => fod.ItemType == packageItem.ItemType);
                        // only create a new item if one doesn't exist

                        if (inventoryItem == null)
                        {
                            _applicationDbContext.InventoryItems.Add(CreateNewInventoryItemInstance(packageItem, player.Id));
                        }
                    }
                    // we have some sort of resource.
                    else
                    {
                        InventoryItem inventoryItem = player.InventoryItems.FirstOrDefault(fod => fod.ItemType == packageItem.ItemType);
                        if(inventoryItem == null)
                        {
                            _applicationDbContext.InventoryItems.Add(CreateNewInventoryItemInstance(packageItem, player.Id));
                        }
                        else
                        {
                            inventoryItem.ItemCount += packageItem.ItemCountToBeAdded;
                            _applicationDbContext.Entry(inventoryItem).State = EntityState.Modified;
                        }
                    }
                    // add a bin if necessary
                }

            }
            catch(Exception ex)
            {

            }









            // add the associated items to the inventory
            // for each item that needs it, add an inventory bin
            // add a new bank account transaction. 






            var amount = purchaseItem.UsePremium ? marketPackageDefinition.CostInPlat : marketPackageDefinition.CostInCredits;
            var currencyType = purchaseItem.UsePremium ? CurrencyType.Platinum : CurrencyType.StandardCredits;


            var addAccountTransactionResult = _addAccountTransactionHandler.Handle(new AddAccountTransaction() { AccountId = purchaseItem.AccountId, Amount = amount, BankAccountTransactionType = BankAccountTransactionType.Credit, BankAccountType = currencyType, MemoCode = "ItemSale" });

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


        InventoryItem CreateNewInventoryItemInstance(MarketPackageItemDefinition packageDefinition, Guid playerId)
        {
            return   new InventoryItem()
            {
                PlayerId = playerId,
                ItemCount = Math.Max(packageDefinition.ItemCountToBeAdded, 1),
                ItemName = packageDefinition.ItemName, 
                InternalInventoryItemType= packageDefinition.InternalInventoryItemType,
                ExtraCapacity = packageDefinition.ExtraCapacity, 
                ExtraRemaining = packageDefinition.ExtraCapacity, 
                XP = 0, 
                UpgradeVer = packageDefinition.UpgradeVer,  
                UpgradeFingerprint = packageDefinition.UpgradeFingerprint, 
                ItemType = packageDefinition.ItemType,
                UnlockLevel = packageDefinition.UnlockLevel
                
            };
        }
    }
}