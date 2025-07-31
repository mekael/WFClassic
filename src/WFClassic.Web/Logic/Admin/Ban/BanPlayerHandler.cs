using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.WFAuth.WFLogout;

namespace WFClassic.Web.Logic.Admin.Ban
{


    public class BanPlayerHandler
    {

        private ILogger<BanPlayerHandler> _logger;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly ApplicationDbContext _applicationDbContext;

        public BanPlayerHandler(IUserStore<ApplicationUser> userStore, ILogger<BanPlayerHandler> logger, ApplicationDbContext applicationDbContext)
        {
            this._userStore = userStore;
            this._logger = logger;
            this._applicationDbContext = applicationDbContext;
        }


        public BanPlayerResult Handle(BanPlayer banPlayer)
        {
            BanPlayerResult banPlayerResult = new BanPlayerResult();
            var validationResults = new BanPlayerValidator().Validate(banPlayer);
            this._logger.LogInformation("BanPlayerHandler =>   playerToBan {AccountId} => Updating users table, setting nonce to 0 and currently logged in to false", banPlayer.AccountId);

            if (!validationResults.IsValid)
            {
                this._logger.LogError("{ClassName} => playerToBan {AccountId} => Validation Errors {Errors}", this.GetType().Name, banPlayer.AccountId, string.Join("\n", validationResults.Errors.Select(s => s.ErrorMessage)));
                banPlayerResult.BanPlayerResultStatus = BanPlayerResultStatus.ValidationErrors;
                return banPlayerResult;
            }


            // if the permaban flag is set, then we need to use DateTimeOffset.Max

            DateTimeOffset banDate = banPlayer.BanInEffectUntil.HasValue ? banPlayer.BanInEffectUntil.Value.Date : DateTimeOffset.MaxValue.Date;

            ApplicationUser user = null;
            bool hasExistingBan = false;
            try
            {
                this._logger.LogInformation("BanPlayerHandler =>   playerToBan {AccountId} => Searching for user and existing bans", banPlayer.AccountId);
                hasExistingBan = this._applicationDbContext.PlayerBans.Any(w => w.ApplicationUserId == banPlayer.AccountId
                                                                                        && w.BanInEffectUntil >= banDate
                                                                                        && !w.BanRescindedOnDate.HasValue);
                user = this._userStore.FindByIdAsync(banPlayer.AccountId.ToString(), CancellationToken.None).Result;
                this._logger.LogInformation("BanPlayerHandler =>   playerToBan {AccountId} => User/ban search complete", banPlayer.AccountId);
            }
            catch (Exception ex)
            {
                this._logger.LogError("{ClassName} => playerToBan {AccountId} => Errors while searching for player and associated bans {Errors}", this.GetType().Name, banPlayer.AccountId, ex.ToString());
                banPlayerResult.BanPlayerResultStatus = BanPlayerResultStatus.DatabaseErrors;
                return banPlayerResult;
            }


            // check to see if the player is already banned. 
            // if the current ban ends after the proposed ban, then leave early, tell the user that 
            // they need to rescind the current one first. 
            if (hasExistingBan)
            {
                this._logger.LogInformation("BanPlayerHandler =>   playerToBan {AccountId} => User is currently banned. Review of existing bans is required", banPlayer.AccountId);
                banPlayerResult.BanPlayerResultStatus = BanPlayerResultStatus.ExistingBanInPlace;
                return banPlayerResult;
            }

            // create new player ban record
            this._logger.LogInformation("BanPlayerHandler =>   playerToBan {AccountId} => No in-progress ban found", banPlayer.AccountId);


            PlayerBan playerBan = new PlayerBan()
            {
                ApplicationUserId = banPlayer.AccountId,
                BanInEffectUntil = banDate,
                BanReason = banPlayer.BanReason,
                BanStartedOn = DateTime.Now,
                BannedByUserId = banPlayer.BannedByUserId
            };


            try
            {

                // make sure to lock the user out, we don't want them to be able to circumvent their ban 
                // or to bother other players.
                user.LockoutEnabled = true;
                user.LockoutEnd = banDate;
                var result = this._userStore.UpdateAsync(user, CancellationToken.None).Result;

                // logout user if logged in 
                this._logger.LogInformation("BanPlayerHandler =>   playerToBan {AccountId} => Updating users table, setting nonce to 0 and currently logged in to false", banPlayer.AccountId);
                this._applicationDbContext.Users.Where(w => w.Id == banPlayer.AccountId).ExecuteUpdate(e => e.SetProperty(sp => sp.CurrentNonce, 0).SetProperty(sp => sp.CurrentlyLoggedIn, false));

                this._logger.LogInformation("BanPlayerHandler =>  playerToBan {AccountId}  => Updating login tracking items.", banPlayer.AccountId);
                var logoutTimestamp = DateTimeOffset.Now;
                this._applicationDbContext.LoginTrackingItems.Where(w => w.ApplicationUserId == banPlayer.AccountId).ExecuteUpdate(e => e.SetProperty(sp => sp.LogoutTimestamp, logoutTimestamp));


                this._applicationDbContext.PlayerBans.Add(playerBan);
                this._applicationDbContext.SaveChanges();
                banPlayerResult.BanPlayerResultStatus = BanPlayerResultStatus.Success;

            }
            catch (Exception ex)
            {
                this._logger.LogError("{ClassName} => playerToBan {AccountId} => Errors while updating player object / logging out / and banning player : {Errors}", this.GetType().Name, banPlayer.AccountId, ex.ToString());
                banPlayerResult.BanPlayerResultStatus = BanPlayerResultStatus.DatabaseErrors;

            }
            return banPlayerResult;
        }

    }
}