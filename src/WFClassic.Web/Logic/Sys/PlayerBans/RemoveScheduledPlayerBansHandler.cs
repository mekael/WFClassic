using Microsoft.AspNetCore.Identity;

using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Sys.PlayerBans;

public class RemoveScheduledPlayerBansHandler
{

    private readonly ApplicationDbContext _applicationDbContext;
    private readonly ILogger<RemoveScheduledPlayerBansHandler> _logger;
    private readonly IUserStore<ApplicationUser> _userStore;

    public RemoveScheduledPlayerBansHandler(ILogger<RemoveScheduledPlayerBansHandler> logger, ApplicationDbContext applicationDbContext)
    {
        this._applicationDbContext = applicationDbContext;
        this._logger = logger;
    }

    public void Handle()
    {
        List<PlayerBan> playerBans = null;
        DateTimeOffset banInEffectUntilDate = DateTime.Today;

        try
        {
            this._logger.LogInformation("RemoveScheduledPlayerBansHandler => Starting query for player bans");
            playerBans = this._applicationDbContext.PlayerBans.ToList().Where(w => w.BanInEffectUntil <= banInEffectUntilDate && !w.BanRescindedOnDate.HasValue).ToList();
        }
        catch (Exception ex)
        {
            this._logger.LogError("RemoveScheduledPlayerBansHandler => Exception while searching for player bans {Ex}", ex.ToString());
            return;
        }


        this._logger.LogInformation("RemoveScheduledPlayerBansHandler => Found {PlayerBanCount} players with closable bans", playerBans.Count);
        if (!playerBans.Any())
        {
            this._logger.LogInformation("RemoveScheduledPlayerBansHandler => No bans found. Leaving early");
            return;
        }

        foreach (var playerBan in playerBans)
        {
            this._logger.LogInformation("RemoveScheduledPlayerBansHandler => Processing ban {BanIOd}", playerBan.Id);
            playerBan.BanRescindedOnDate = banInEffectUntilDate;
            playerBan.BanRescindedReason = "Ban rescinded by scheduled job. ";
            playerBan.BanRescindedBy = "System";
            var user = _userStore.FindByIdAsync(playerBan.ApplicationUserId.ToString(), CancellationToken.None).Result;

            if (user.LockoutEnabled && user.LockoutEnd.HasValue && user.LockoutEnd.Value.Date == banInEffectUntilDate)
            {
                this._logger.LogInformation("RemoveScheduledPlayerBansHandler => updating lockout attributes for user {UserId} ", user.Id);
                user.LockoutEnabled = false;
                user.LockoutEnd = null;
                var cat = this._userStore.UpdateAsync(user, CancellationToken.None).Result;
            }
            _applicationDbContext.Entry(playerBan).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        this._logger.LogInformation("RemoveScheduledPlayerBansHandler => updating db records");
        this._applicationDbContext.SaveChanges();
        return;
    }

}