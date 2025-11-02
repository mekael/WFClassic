using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Logic.QualityOfLife.InventoryChanges;

public class InventoryChangeHandler
{

    private readonly ApplicationDbContext _applicationDbContext;
    private readonly ILogger<InventoryChangeHandler> _logger;
    private readonly WFClassicAdditionalData _wfClassicAdditionalData;

    public InventoryChangeHandler(ApplicationDbContext applicationDbContext, ILogger<InventoryChangeHandler> logger, WFClassicAdditionalData wfClassicAdditionalData)
    {
        this._logger = logger;
        this._applicationDbContext = applicationDbContext;
        this._wfClassicAdditionalData = wfClassicAdditionalData;
    }

    // can set frames, sentinels, and weapons to level 30
    public void SetInvGroupToLevelThirty(Guid userId, InternalInventoryItemType inventoryType)
    {

        try
        {
            this._logger.LogInformation("{ClassName} => SetInvGroupToLevelThirty => userId {UserID} => updating all inventory items of type {inventoryType} to level 30", this.GetType().Name, userId, inventoryType);
            this._applicationDbContext.Database.ExecuteSql($"Update InventoryItems set Xp=1000000 where  playerId in (select id from players where ApplicationUserId = {userId}) and internalinventoryitemtype = {inventoryType}");
            this._logger.LogInformation("{ClassName} => SetInvGroupToLevelThirty => userId {UserID} => Successfully updated all inventory items of type {inventoryType}", this.GetType().Name, userId, inventoryType);

        }
        catch (Exception ex) {
            this._logger.LogInformation("{ClassName} => SetInvGroupToLevelThirty => userId {UserID} => Exception while updating inventory {Exception}", this.GetType().Name, userId, ex);
        }
    }

    public void AddPotatoesToInvGroup(Guid userId, InternalInventoryItemType inventoryType)
    {

        try
        {
            this._logger.LogInformation("{ClassName} => AddPotatoesToInvGroup => userId {UserID} => Adding potatoes to {InventoryType}", this.GetType().Name, userId, inventoryType);
            this._applicationDbContext.Database.ExecuteSql($"Update InventoryItems set UnlockLevel = 1 where  playerId in (select id from players where ApplicationUserId = {userId}) and internalinventoryitemtype = {inventoryType}");
            this._logger.LogInformation("{ClassName} => AddPotatoesToInvGroup => userId {UserID} => Added potatoes to {inventoryType}", this.GetType().Name, userId, inventoryType);
        }
        catch (Exception ex)
        {
            this._logger.LogInformation("{ClassName} => AddPotatoesToInvGroup => userId {UserID} => Exception while updating inventory {Exception}", this.GetType().Name, userId, ex);
        }
    }

    public void SetBoosterExpiryToTheHeatDeathOfTheUniverse(Guid userId) 
    {
        try
        {
            this._logger.LogInformation("{ClassName} => SetBoosterExpiryToTheHeatDeathOfTheUniverse => userId {UserID} => updating all boosters to 2035", this.GetType().Name, userId);
            this._applicationDbContext.Database.ExecuteSql($"Update InventoryItems set ExpiryDate = '2035-01-01 00:00:00.000000-05:00' where  playerId in (select id from players where ApplicationUserId = {userId}) and internalinventoryitemtype = {InternalInventoryItemType.Boosters}");
            this._logger.LogInformation("{ClassName} => SetBoosterExpiryToTheHeatDeathOfTheUniverse => userId {UserID} => Boosters Updated", this.GetType().Name, userId);
        }
        catch (Exception ex)
        {
            this._logger.LogInformation("{ClassName} => SetBoosterExpiryToTheHeatDeathOfTheUniverse => userId {UserID} => Exception while updating boosters {Exception}", this.GetType().Name, userId, ex);
        }

    }


}
