using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;

namespace WFClassic.Web.Logic.Sys.SystemLogout
{
    public class MassLogoutUsersHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<MassLogoutUsersHandler> _logger;

        public MassLogoutUsersHandler(ApplicationDbContext applicationDbContext,
                                    ILogger<MassLogoutUsersHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }


        public void Handle()
        {
            int orphanLoginCount = 0;

            try 
            {
                _logger.LogInformation("MassLogoutUsersHandler => Checking to see if orphan logins are present");
                orphanLoginCount = _applicationDbContext.Users.Count(w => w.CurrentNonce > 0);
            }
            catch (Exception ex)
            {
                _logger.LogError("MassLogoutUsersHandler => Exception while querying for orphan count. {Ex}",ex);
                throw;
            }

            if (orphanLoginCount == 0)
            {
                _logger.LogInformation("MassLogoutUsersHandler => No orphans found.");
                return;
            }
            _logger.LogInformation("MassLogoutUsersHandler => Found {LoginCount} orphans",orphanLoginCount );

            try
            {
                _logger.LogInformation("MassLogoutUsersHandler => Updating users table, setting nonce to 0 and currently logged in to false");
                _applicationDbContext.Users.Where(w=> w.CurrentNonce!=0).ExecuteUpdate(e => e.SetProperty(sp => sp.CurrentNonce, 0).SetProperty(sp=>sp.CurrentlyLoggedIn,false));
                _logger.LogInformation("MassLogoutUsersHandler => Updating login tracking items.");
                var logoutTimestamp = DateTimeOffset.Now;
                _applicationDbContext.LoginTrackingItems.Where(w=> !w.LogoutTimestamp.HasValue).ExecuteUpdate(e => e.SetProperty(sp=> sp.LogoutTimestamp, logoutTimestamp));
            }
            catch (Exception ex)
            {
                _logger.LogError("MassLogoutUsersHandler => Exception during forced logout {Exception}", ex);
                throw;
            }
        }
    }
}
