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
                _logger.LogInformation("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Starting Query for player and market item", purchaseItem.AccountId, purchaseItem.Nonce);
                player = _applicationDbContext.Players
                                                    .Include(i => i.InventoryItems)
                                                    .Include(i => i.PlayerPurchaseRecords)
                                                    .Include(i => i.InventoryBins)
                                                    .FirstOrDefault(w => w.ApplicationUserId == purchaseItem.AccountId);
                marketPackageDefinition = _applicationDbContext.MarketPackageDefinitions.AsNoTracking()
                                                                                        .Include(i => i.MarketPackageItemDefinitions)
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
            // check to see if the player has already purchased the item and if it is a one time purchase or not


            if (player.PlayerPurchaseRecords.Any(a => a.MarketPackageDefinitionId == marketPackageDefinition.Id) && !marketPackageDefinition.CanBePurchasedMultipleTimes)
            {
                _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Item  {ProductName} can only be purchased once", purchaseItem.AccountId, purchaseItem.Nonce, purchaseItem.ProductName);
                result.PurchaseItemResultStatus = PurchaseItemResultStatus.ValidationErrors;
                return result;
            }

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

            // this is essentially UpdateInventory, but inventory is provided server side rather than client
            // the call is coming from inside the house. 
            var currencyType = purchaseItem.UsePremium == 1 ? CurrencyType.Platinum : CurrencyType.StandardCredits;

            try
            {

                foreach (var packageItem in marketPackageDefinition.MarketPackageItemDefinitions)
                {
                    if (packageItem.IsUniqueItem && packageItem.CanBeAddedRepeatedly)
                    {
                        // weapons, suits, etc
                        _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Adding {PackageItemName} which is 'unique' but can be added multiple time", purchaseItem.AccountId, purchaseItem.Nonce, packageItem.ItemName);
                        _applicationDbContext.InventoryItems.Add(CreateNewInventoryItemInstance(packageItem, player.Id, currencyType));
                    }
                    // keys and such, i think. 
                    else if (packageItem.IsUniqueItem && !packageItem.CanBeAddedRepeatedly && !player.InventoryItems.Any(fod => fod.ItemType == packageItem.ItemType))
                    {
                        _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Adding {PackageItemName}. it's unique but can be added multiple times", purchaseItem.AccountId, purchaseItem.Nonce, packageItem.ItemName);
                        _applicationDbContext.InventoryItems.Add(CreateNewInventoryItemInstance(packageItem, player.Id, currencyType));
                    }
                    // we have some sort of resource.
                    else
                    {
                        InventoryItem inventoryItem = player.InventoryItems.FirstOrDefault(fod => fod.ItemType == packageItem.ItemType);
                        if (inventoryItem == null)
                        {
                            _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Adding {PackageItemName}. ", purchaseItem.AccountId, purchaseItem.Nonce, packageItem.ItemName);
                            _applicationDbContext.InventoryItems.Add(CreateNewInventoryItemInstance(packageItem, player.Id, currencyType));
                        }
                        else
                        {
                            _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Updating {PackageItemName}. ", purchaseItem.AccountId, purchaseItem.Nonce, packageItem.ItemName);
                            inventoryItem.ItemCount += packageItem.ItemCountToBeAdded;
                            _applicationDbContext.Entry(inventoryItem).State = EntityState.Modified;
                        }
                    }

                    if (packageItem.AddInventoryBin && currencyType == CurrencyType.Platinum)
                    {
                        _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Adding Inventory bin as  {PackageItemName} grants one. ", purchaseItem.AccountId, purchaseItem.Nonce, packageItem.ItemName);
                        var bin = player.InventoryBins.First(f => f.InventoryBinType == packageItem.InventoryBinTypeToAdd);
                        bin.Slots++;
                        _applicationDbContext.Entry(bin).State = EntityState.Modified;
                    }
                    // add a bin if necessary
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("PurchaseItemHandler => accountId {AccountID} nonce {Nonce} => Exception while processing  {ProductName} : {Ex}", purchaseItem.AccountId, purchaseItem.Nonce, purchaseItem.ProductName, ex );
                result.PurchaseItemResultStatus = PurchaseItemResultStatus.ValidationErrors;
                return result;
            }

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


        InventoryItem CreateNewInventoryItemInstance(MarketPackageItemDefinition packageDefinition, Guid playerId, CurrencyType currencyType = CurrencyType.StandardCredits)
        {
            return new InventoryItem()
            {
                PlayerId = playerId,
                ItemCount = Math.Max(packageDefinition.ItemCountToBeAdded, 1),
                ItemName = packageDefinition.ItemName,
                InternalInventoryItemType = packageDefinition.InternalInventoryItemType,
                ExtraCapacity = packageDefinition.ExtraCapacity,
                ExtraRemaining = packageDefinition.ExtraCapacity,
                XP = 0,
                UpgradeVer = packageDefinition.UpgradeVer ,
                UpgradeFingerprint = packageDefinition.UpgradeFingerprint,
                ItemType = packageDefinition.ItemType,
                UnlockLevel = currencyType == CurrencyType.Platinum ? packageDefinition.UnlockLevel :0
            };
        }
    }
}