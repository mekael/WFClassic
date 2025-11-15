using Coravel.Invocable;

using Microsoft.EntityFrameworkCore;

using WFClassic.Web.Data;
using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Logic.Sys.SystemLogout
{
    public class MassLogoutUsersHandler : IInvocable
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<MassLogoutUsersHandler> _logger;
        private readonly InMemoryLoginTracking _inMemoryLoginTracking;

        public MassLogoutUsersHandler(ApplicationDbContext applicationDbContext,
                                    ILogger<MassLogoutUsersHandler> logger, InMemoryLoginTracking inMemoryLoginTracking)
        {
            this._applicationDbContext = applicationDbContext;
            this._logger = logger;
            this._inMemoryLoginTracking = inMemoryLoginTracking;
        }



        public async Task Invoke()
        {
            this.Handle();
        }

        public void Handle()
        {
            int orphanLoginCount = 0;

            try
            {
                this._logger.LogInformation("MassLogoutUsersHandler => Checking to see if orphan logins are present");
                orphanLoginCount = this._applicationDbContext.Users.Count(w => w.CurrentNonce > 0);
            }
            catch (Exception ex)
            {
                this._logger.LogError("MassLogoutUsersHandler => Exception while querying for orphan count. {Ex}", ex);
                throw;
            }
            this._inMemoryLoginTracking.LoggedInUserListing = new Dictionary<Guid, InMemoryLoginTrackingItem>();
            if (orphanLoginCount == 0)
            {
                this._logger.LogInformation("MassLogoutUsersHandler => No orphans found.");
                return;
            }
            this._logger.LogInformation("MassLogoutUsersHandler => Found {LoginCount} orphans", orphanLoginCount);

            try
            {
                this._logger.LogInformation("MassLogoutUsersHandler => Updating users table, setting nonce to 0 and currently logged in to false");
                this._applicationDbContext.Users.Where(w => w.CurrentNonce != 0).ExecuteUpdate(e => e.SetProperty(sp => sp.CurrentNonce, 0).SetProperty(sp => sp.CurrentlyLoggedIn, false));
                this._logger.LogInformation("MassLogoutUsersHandler => Updating login tracking items.");
                var logoutTimestamp = DateTimeOffset.Now;
                this._applicationDbContext.LoginTrackingItems.Where(w => !w.LogoutTimestamp.HasValue).ExecuteUpdate(e => e.SetProperty(sp => sp.LogoutTimestamp, logoutTimestamp));
            }
            catch (Exception ex)
            {
                this._logger.LogError("MassLogoutUsersHandler => Exception during forced logout {Exception}", ex);
                throw;
            }
        }
    }
}