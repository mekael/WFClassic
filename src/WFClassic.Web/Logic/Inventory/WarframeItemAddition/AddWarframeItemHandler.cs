using Microsoft.EntityFrameworkCore;

using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Inventory.WarframeItemAddition
{
    public class AddWarframeItemHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<AddWarframeItemHandler> _logger;

        public AddWarframeItemHandler(ApplicationDbContext applicationDbContext, ILogger<AddWarframeItemHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public AddWarframeItemResult Handle(AddWarframeItem addWarframeItem)
        {
            AddWarframeItemResult result = new AddWarframeItemResult();
            var validationResults = new AddWarframeItemValidator().Validate(addWarframeItem);

            if (!validationResults.IsValid)
            {
                _logger.LogError("UpdateLoadoutHandler => accountId {AccountID}   => Validation failure {ValidationErrors}", addWarframeItem.AccountId, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.AddWarframeItemResultStatus = AddWarframeItemResultStatus.ValidationErrors;
                return result;
            }

            WarframeItem warframeItem = null;
            List<InventoryItem> inventoryItems = null;
            List<InventoryBin> inventoryBins = null;
            Guid playerId = Guid.Empty;

            try
            {
                _logger.LogInformation("AddWarframeItemHandler => accountId {AccountID} itemType {ItemType}  =>  ", addWarframeItem.AccountId, addWarframeItem.ItemType);
                playerId = _applicationDbContext.Players.First(f => f.ApplicationUserId == addWarframeItem.AccountId).Id;
                warframeItem = _applicationDbContext.WarframeItems.Include(i => i.WarframeItemComponents).FirstOrDefault(fod => fod.ItemType == addWarframeItem.ItemType && fod.WarframeItemLocation == addWarframeItem.WarframeItemLocation);
                inventoryItems = _applicationDbContext.InventoryItems.Where(w => w.Player.Id == playerId).ToList();
                inventoryBins = _applicationDbContext.InventoryBins.Where(w => w.InventoryId == playerId).ToList();
                _logger.LogInformation("AddWarframeItemHandler => accountId {AccountID} itemType {ItemType}  =>  ", addWarframeItem.AccountId, addWarframeItem.ItemType);
            }
            catch (Exception ex)
            {
                result.AddWarframeItemResultStatus = AddWarframeItemResultStatus.DatabaseErrors;
                _logger.LogError("AddWarframeItemHandler => accountId {AccountID} itemType {ItemType}  => exception while searching for inventory and warframe item {Ex}  ", addWarframeItem.AccountId, addWarframeItem.ItemType, ex.ToString());
                return result;
            }



            foreach (var warframeItemComponent in warframeItem.WarframeItemComponents)
            {
                if (warframeItemComponent.IsUniqueItem)
                {
                    _logger.LogInformation("AddWarframeItemHandler => accountId {AccountID} itemType {ItemType}  =>   adding unique item {UniqueWarframeItemComponent} ", addWarframeItem.AccountId, addWarframeItem.ItemType, warframeItemComponent.ItemType);

                    _applicationDbContext.InventoryItems.Add(new InventoryItem()
                    {
                        ItemCount = warframeItemComponent.Count,
                        ItemType = warframeItemComponent.ItemType,
                        ItemName = warframeItemComponent.ItemName,
                        PlayerId = playerId,
                        InternalInventoryItemType = warframeItemComponent.InternalInventoryItemType,
                        UpgradeVer = warframeItemComponent.UpgradeVer,
                        UpgradeFingerprint = warframeItemComponent.UpgradeFingerprint,
                        Charge = warframeItemComponent.Charge,
                        ExtraCapacity = warframeItemComponent.ExtraCapacity,
                        ExtraRemaining = warframeItemComponent.ExtraRemaining,
                        UnlockLevel = warframeItemComponent.UnlockLevel,
                        XP = warframeItemComponent.XP,
                        ExpiryDate = warframeItemComponent.InternalInventoryItemType == Data.Enums.InternalInventoryItemType.Boosters ? DateTime.Now.AddDays(addWarframeItem.NumberOfDaysForBooster) : DateTime.MinValue
                    });
                }
                else
                {
                    var existingItem = inventoryItems.FirstOrDefault(fod => fod.ItemType == warframeItem.ItemType);

                    if (existingItem == null)
                    {
                        _logger.LogInformation("AddWarframeItemHandler => accountId {AccountID} itemType {ItemType}  => updating resource  {UniqueWarframeItemComponent} ", addWarframeItem.AccountId, addWarframeItem.ItemType, warframeItemComponent.ItemType);

                        _applicationDbContext.InventoryItems.Add(new InventoryItem()
                        {
                            ItemCount = warframeItemComponent.Count,
                            ItemType = warframeItemComponent.ItemType,
                            ItemName = warframeItemComponent.ItemName,
                            PlayerId = playerId,
                            InternalInventoryItemType = warframeItemComponent.InternalInventoryItemType,
                            UpgradeVer = warframeItemComponent.UpgradeVer,
                            UpgradeFingerprint = warframeItemComponent.UpgradeFingerprint,
                            Charge = warframeItemComponent.Charge,
                            ExtraCapacity = warframeItemComponent.ExtraCapacity,
                            ExtraRemaining = warframeItemComponent.ExtraRemaining,
                            UnlockLevel = warframeItemComponent.UnlockLevel,
                            XP = warframeItemComponent.XP
                        });
                    }
                    else
                    {
                        _logger.LogInformation("AddWarframeItemHandler => accountId {AccountID} itemType {ItemType}  =>  Cannot find resource for    {UniqueWarframeItemComponent} ", addWarframeItem.AccountId, addWarframeItem.ItemType, warframeItemComponent.ItemType);
                        existingItem.ItemCount += warframeItemComponent.Count;
                        existingItem.Charge += warframeItemComponent.Charge;
                        _applicationDbContext.Entry(existingItem).State = EntityState.Modified;
                    }
                }
                if (warframeItemComponent.AddInventoryBin)
                {
                    _logger.LogInformation("AddWarframeItemHandler => accountId {AccountID} itemType {ItemType}  => Adding bin for    {UniqueWarframeItemComponent} ", addWarframeItem.AccountId, addWarframeItem.ItemType, warframeItemComponent.ItemType);
                    InventoryBin binToModify = inventoryBins.FirstOrDefault(fod => fod.InventoryBinType == warframeItemComponent.InventoryBinTypeToAdd);
                    if (binToModify != null)
                    {                        
                        if(warframeItemComponent.NumberOfBinsToAdd > 0)
                        {
                            binToModify.Extra += warframeItemComponent.NumberOfBinsToAdd;
                        }
                        binToModify.Slots += warframeItemComponent.NumberOfBinsToAdd;
                    }
                }
            }

            try
            {
                _logger.LogInformation("AddWarframeItemHandler => accountId {AccountID} itemType {ItemType}  =>  Updating database", addWarframeItem.AccountId, addWarframeItem.ItemType);
                _applicationDbContext.SaveChanges();
                result.AddWarframeItemResultStatus = AddWarframeItemResultStatus.Success;
                _logger.LogInformation("AddWarframeItemHandler => accountId {AccountID} itemType {ItemType}  => Database update complete ", addWarframeItem.AccountId, addWarframeItem.ItemType);
            }
            catch (Exception ex)
            {
                result.AddWarframeItemResultStatus = AddWarframeItemResultStatus.DatabaseErrors;
                _logger.LogError("AddWarframeItemHandler => accountId {AccountID} itemType {ItemType}  => exception while updating database {Ex}  ", addWarframeItem.AccountId, addWarframeItem.ItemType, ex.ToString());
            }

            return result;
        }
    }
}