using Microsoft.EntityFrameworkCore;

using WFClassic.Web.Data;

namespace WFClassic.Web.Logic.Sys.BoosterUpdates;

public class CleanupExpiredBoostersHandler
{

    private readonly ApplicationDbContext _applicationDbContext;
    private readonly ILogger<CleanupExpiredBoostersHandler> _logger;

    public CleanupExpiredBoostersHandler(ILogger<CleanupExpiredBoostersHandler> logger, ApplicationDbContext applicationDbContext)
    {
        this._applicationDbContext = applicationDbContext;
        this._logger = logger;
    }

    public void Handle()
    {

        try
        {
            this._logger.LogInformation("CleanupExpiredBoostersHandler => Starting query for player bans");
            // delete any expired boosters before obtaining 
            this._applicationDbContext.Database.ExecuteSql(@$"
                                                            DELETE from inventoryitems 
                                                            where InternalInventoryItemType =8
                                                            and expirydate < current_timestamp"
                                                            );

            // get all of the 
        }
        catch (Exception ex)
        {
            this._logger.LogError("CleanupExpiredBoostersHandler => Exception while searching for player bans {Ex}", ex.ToString());
            return;
        }

        return;
    }

}