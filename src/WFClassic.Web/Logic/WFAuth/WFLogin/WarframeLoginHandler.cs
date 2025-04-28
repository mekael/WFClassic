using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.WFAuth.WFLogin
{
    public class WarframeLoginHandler
    {

        private readonly ILogger<WarframeLoginHandler> _logger;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;



        public WarframeLoginHandler(ILogger<WarframeLoginHandler> logger, ApplicationDbContext applicationDbContext,
            SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            this._logger = logger;
            this._applicationDbContext = applicationDbContext;
            this._signInManager = signInManager;
            this._userManager = userManager;
        }


        public async Task<WarframeLoginResult> Handle(WarframeLoginRequest warframeLoginRequest)
        {

            WarframeLoginResult warframeLoginResult = new WarframeLoginResult();

            var validationResults = new WarframeLoginRequestValidator().Validate(warframeLoginRequest);

            _logger.LogInformation("WarframeLoginHandler => email {email} =>  Starting Validation", warframeLoginRequest.email);

            if (!validationResults.IsValid)
            {
                _logger.LogError("WarframeLoginHandler => email {email} =>  Invalid credentials", warframeLoginRequest.email);
                warframeLoginResult.WarframeLoginResultStatus = WarframeLoginResultStatus.BadRequest;
                return warframeLoginResult;

            }


            _logger.LogInformation("WarframeLoginHandler => email {email} =>  Searching for user", warframeLoginRequest.email);

            string upperPassword = warframeLoginRequest.password.ToUpper();

            var user = await _userManager.FindByEmailAsync(warframeLoginRequest.email);


            if (user == null)
            {
                _logger.LogWarning("WarframeLoginHandler => email {email} =>  User not found: ", warframeLoginRequest.email);
                warframeLoginResult.WarframeLoginResultStatus = WarframeLoginResultStatus.UserNotFound;
                return warframeLoginResult;
            }
            _logger.LogInformation("WarframeLoginHandler => email {email} =>  User Found", warframeLoginRequest.email);

            _logger.LogInformation("WarframeLoginHandler => email {email} =>  Signing in", warframeLoginRequest.email);

            var result = await _signInManager.PasswordSignInAsync(warframeLoginRequest.email, upperPassword, false, false);


            if (!result.Succeeded)
            {
                _logger.LogWarning("WarframeLoginHandler => email {email} =>  Invalid credentials ", warframeLoginRequest.email);
                warframeLoginResult.WarframeLoginResultStatus = WarframeLoginResultStatus.InvalidCredentials;
                return warframeLoginResult;
            }
            _logger.LogInformation("WarframeLoginHandler => email {email} =>  Successfully signed in", warframeLoginRequest.email);


            Random rnd = new Random();

            long newNonce = rnd.NextInt64(0, long.MaxValue);
            DateTimeOffset loginTimestamp = DateTimeOffset.Now;

            user.CurrentNonce = newNonce;
            user.TotalNumberOfDaysLoginCount += user.LastLoginTimestamp.Date < DateTime.Today ? 1 : 0;
            user.LoginStreak = DetermineLoginStreak(user.LastLoginTimestamp, user.LoginStreak);
            user.CurrentlyLoggedIn = true;
            user.LastLoginTimestamp = loginTimestamp;
            _logger.LogInformation("WarframeLoginHandler => email {email} =>  Updating user login", warframeLoginRequest.email);


            IdentityResult identityResult = null;
            try
            {
                _logger.LogInformation("WarframeLoginHandler => email {email} =>  Updating user login", warframeLoginRequest.email);
                identityResult = await _userManager.UpdateAsync(user);
                _logger.LogInformation("WarframeLoginHandler => email {email} =>  User updated", warframeLoginRequest.email);
            }
            catch (Exception ex)
            {
                _logger.LogError("WarframeLoginHandler => email {email} =>  Exception while updating user login {Ex}", warframeLoginRequest.email, ex);
                warframeLoginResult.WarframeLoginResultStatus = WarframeLoginResultStatus.Failure;
                return warframeLoginResult;
            }

            if (!identityResult.Succeeded)
            {
                warframeLoginResult.WarframeLoginResultStatus = WarframeLoginResultStatus.Failure;
                _logger.LogError("WarframeLoginHandler => email {email} =>  Error while updating user {Errors}", warframeLoginRequest.email, identityResult.Errors.Select(s=>s.Description));
            }
            else
            {
                warframeLoginResult.WarframeLoginResultStatus = WarframeLoginResultStatus.Success;

                warframeLoginResult.WarframeLoginResultDetails = new WarframeLoginResultDetails()
                {
                    id = user.Id.ToString(),
                    BuildLabel = "2013.03.25.11.45/",
                    DisplayName = user.DisplayName,
                    NatHash = "0",
                    Nonce = user.CurrentNonce,
                    SteamId = user.SteamId
                };

            }

            return warframeLoginResult;
        }

        int DetermineLoginStreak(DateTimeOffset lastLoginTimestamp, int currentStreak)
        {
            if (lastLoginTimestamp.Date == DateTime.Today)
            {
                //we'ven already  incremented
            }
            else if (lastLoginTimestamp.Date == DateTime.Today.AddDays(-1))
            {
                currentStreak += 1;
            }
            else
            {
                currentStreak = 0;
            }


            return currentStreak;
        }
    }
}
