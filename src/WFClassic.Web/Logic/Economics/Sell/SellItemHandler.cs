using WFClassic.Web.Data.Models;
using WFClassic.Web.Data;
using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Logic.Credits.Add;
using System.Linq;

namespace WFClassic.Web.Logic.Economics.Sell
{
    public class SellItemHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<SellItemHandler> _logger;
        private AddAccountTransactionHandler _addAccountTransactionHandler;

        public SellItemHandler(ApplicationDbContext applicationDbContext, ILogger<SellItemHandler> logger, AddAccountTransactionHandler addAccountTransactionHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _addAccountTransactionHandler = addAccountTransactionHandler;
        }

        public SellItemResult Handle(SellItem sellItem)
        {
            SellItemResult result = new SellItemResult();
            var validationResults = new SellItemValidator().Validate(sellItem);

            if (!validationResults.IsValid)
            {
                _logger.LogError("SellItemHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", sellItem.AccountId, sellItem.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.SellItemResultStatus = SellItemResultStatus.ValidationErrors;
                return result;
            }

            Player player = null;

            try
            {
                _logger.LogInformation("SellItemHandler => accountId {AccountID} nonce {Nonce} => Starting Query for player", sellItem.AccountId, sellItem.Nonce);
                player = _applicationDbContext.Players
                                                    .Include(i => i.InventoryItems)
                                                    .FirstOrDefault(w => w.ApplicationUserId == sellItem.AccountId);
                _logger.LogInformation("SellItemHandler => accountId {AccountID} nonce {Nonce} => Query Complete for player ", sellItem.AccountId, sellItem.Nonce);

            }
            catch (Exception ex)
            {
                _logger.LogError("SellItemHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", sellItem.AccountId, sellItem.Nonce, ex);
                result.SellItemResultStatus = SellItemResultStatus.DatabaseErrors;
                return result;
            }




            List<InventoryItem> inventoryItemsToUpdate = new List<InventoryItem>();
            bool canBeUpdated = true;

            try
            {
                _logger.LogInformation("SellItemHandler => accountId {AccountID} nonce {Nonce} => Creating overall list of items to sell  ", sellItem.AccountId, sellItem.Nonce);
                List<IncomingItemToSell> itemsToSell = new List<IncomingItemToSell>()
                                        .Union(sellItem.IncomingSaleJson.Items.Consumables)
                                        .Union(sellItem.IncomingSaleJson.Items.Upgrades)
                                        .Union(sellItem.IncomingSaleJson.Items.WeaponSkins)
                                        .Union(sellItem.IncomingSaleJson.Items.Robotics)
                                        .Union(sellItem.IncomingSaleJson.Items.Boosters)
                                        .Union(sellItem.IncomingSaleJson.Items.Packages)
                                        .Union(sellItem.IncomingSaleJson.Items.FlavourItems)
                                        .Union(sellItem.IncomingSaleJson.Items.MiscItems)
                                        .Union(sellItem.IncomingSaleJson.Items.Cards)
                                        .Union(sellItem.IncomingSaleJson.Items.Recipes)
                                        .Union(sellItem.IncomingSaleJson.Items.CreditBundles)
                                        .ToList()
                                        ;

                List<UniqueIncomingItemToSell> uniqueItemsToSell = new List<UniqueIncomingItemToSell>()
                        .Union(sellItem.IncomingSaleJson.Items.LongGuns)
                        .Union(sellItem.IncomingSaleJson.Items.Suits)
                        .Union(sellItem.IncomingSaleJson.Items.Melee)
                        .Union(sellItem.IncomingSaleJson.Items.Pistols)
                        .Union(sellItem.IncomingSaleJson.Items.Sentinels)
                        .Union(sellItem.IncomingSaleJson.Items.SentinelWeapons)
                        .ToList()
                        ;



                foreach (var itemToSell in itemsToSell)
                {
                    InventoryItem inventoryItem = player.InventoryItems.FirstOrDefault(fod => fod.ItemType == itemToSell.String);

                    if(inventoryItem == null)
                    {
                        _logger.LogError("SellItemHandler => accountId {AccountID} nonce {Nonce} => unable to find item {itemId} ", sellItem.AccountId, sellItem.Nonce, itemToSell.String);
                        canBeUpdated = false;
                    }
                    else if (inventoryItem.ItemCount - itemToSell.Count < 0)
                    {
                        _logger.LogError("SellItemHandler => accountId {AccountID} nonce {Nonce} => User does not have enough of item on hand {itemId} ", sellItem.AccountId, sellItem.Nonce, itemToSell.String);
                        canBeUpdated = false;
                    }
                    else
                    {
                        _logger.LogInformation("SellItemHandler => accountId {AccountID} nonce {Nonce} => Updating item count for {itemId} ", sellItem.AccountId, sellItem.Nonce, itemToSell.String);
                        inventoryItem.ItemCount -= itemToSell.Count;
                        inventoryItemsToUpdate.Add(inventoryItem);
                    }
                }

                foreach (var uniqueItemToSell in uniqueItemsToSell)
                {
                    InventoryItem inventoryItem = player.InventoryItems.FirstOrDefault(fod => fod.Id == uniqueItemToSell.String);

                    if (inventoryItem == null)
                    {
                        _logger.LogError("SellItemHandler => accountId {AccountID} nonce {Nonce} => unable to find item {itemId} ", sellItem.AccountId, sellItem.Nonce, uniqueItemToSell.String);
                        canBeUpdated = false;
                    }
                    else if (inventoryItem.ItemCount - uniqueItemToSell.Count < 0)
                    {
                        _logger.LogError("SellItemHandler => accountId {AccountID} nonce {Nonce} => User does not have enough of item on hand {itemId} ", sellItem.AccountId, sellItem.Nonce, uniqueItemToSell.String);
                        canBeUpdated = false;
                    }
                    else
                    {
                        _logger.LogInformation("SellItemHandler => accountId {AccountID} nonce {Nonce} => Updating item count for {itemId} ", sellItem.AccountId, sellItem.Nonce, uniqueItemToSell.String);
                        inventoryItem.ItemCount -= uniqueItemToSell.Count;
                        inventoryItemsToUpdate.Add(inventoryItem);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("SellItemHandler => accountId {AccountID} nonce {Nonce} => Exception mapping updates : {Ex}", sellItem.AccountId, sellItem.Nonce, ex);
                result.SellItemResultStatus = SellItemResultStatus.MappingFailure;
                return result;
            }

            if (!canBeUpdated)
            {
                _logger.LogError("SellItemHandler => accountId {AccountID} nonce {Nonce} => Issues while trying to find items to update", sellItem.AccountId, sellItem.Nonce);
                result.SellItemResultStatus = SellItemResultStatus.ValidationErrors;
                return result;
            }


           var addAccountTransactionResult =   _addAccountTransactionHandler.Handle(new AddAccountTransaction() { AccountId = sellItem.AccountId, Amount = sellItem.IncomingSaleJson.SellPrice, BankAccountTransactionType = BankAccountTransactionType.Credit, BankAccountType = BankAccountType.StandardCredits, MemoCode = "ItemSale" });

            if (addAccountTransactionResult.AddAccountTransactionResultStatus != AddAccountTransactionResultStatus.Success)
            {
                _logger.LogError("SellItemHandler => accountId {AccountID} nonce {Nonce} => Issues while adding transaction amount to account ", sellItem.AccountId, sellItem.Nonce);
                result.SellItemResultStatus = SellItemResultStatus.ValidationErrors;
                return result;
            }
            try
            {
                _logger.LogInformation("SellItemHandler => accountId {AccountID} nonce {Nonce} => Updating Inventory", sellItem.AccountId, sellItem.Nonce);
                inventoryItemsToUpdate.ForEach(item => _applicationDbContext.Entry(item).State = EntityState.Modified);

                _applicationDbContext.SaveChanges();
                _logger.LogInformation("SellItemHandler => accountId {AccountID} nonce {Nonce} => Inventory Updated", sellItem.AccountId, sellItem.Nonce);
                result.SellItemResultStatus = SellItemResultStatus.Success;

            }
            catch (Exception ex)
            {
                _logger.LogError("SellItemHandler => accountId {AccountID} nonce {Nonce} => Exception while updating inventory items : {Ex}", sellItem.AccountId, sellItem.Nonce, ex);
                result.SellItemResultStatus = SellItemResultStatus.DatabaseErrors;
                return result;
            }
            return result;
        }

 
    }
}
