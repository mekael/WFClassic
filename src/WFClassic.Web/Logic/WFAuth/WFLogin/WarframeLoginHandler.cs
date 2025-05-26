using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Shared;
using WFClassic.Web.Logic.WFAuth.Initialize;

namespace WFClassic.Web.Logic.WFAuth.WFLogin
{
    public class WarframeLoginHandler
    {
        private readonly ILogger<WarframeLoginHandler> _logger;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly CreatePlayerHandler _createPlayerHandler;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly IUserEmailStore<ApplicationUser> _emailStore;


        public WarframeLoginHandler(ILogger<WarframeLoginHandler> logger, ApplicationDbContext applicationDbContext,
            SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IConfiguration configuration,
            CreatePlayerHandler createPlayerHandler, IUserStore<ApplicationUser> userStore )
        {
            this._logger = logger;
            this._applicationDbContext = applicationDbContext;
            this._signInManager = signInManager;
            this._userManager = userManager;
            this._configuration = configuration;
            this._createPlayerHandler = createPlayerHandler;
            this._userStore = userStore;
            this._emailStore = (IUserEmailStore<ApplicationUser>)_userStore;
        }

        public async Task<WarframeLoginResult> Handle(WarframeLoginRequest warframeLoginRequest)
        {
            WarframeLoginResult warframeLoginResult = new WarframeLoginResult();
            bool createUserIfDoesNotExist = _configuration.GetValue<bool>("AutomaticallyCreateAccountUponInitialLogin");

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

            if (user == null && !createUserIfDoesNotExist)
            {
                _logger.LogWarning("WarframeLoginHandler => email {email} =>  User not found: ", warframeLoginRequest.email);
                warframeLoginResult.WarframeLoginResultStatus = WarframeLoginResultStatus.UserNotFound;
                return warframeLoginResult;
            }
            else if(user == null && createUserIfDoesNotExist)
            {
                _logger.LogInformation ("WarframeLoginHandler => email {email} =>  User not found ", warframeLoginRequest.email);
                _logger.LogWarning("WarframeLoginHandler => email {email} =>  Creating new user instance ", warframeLoginRequest.email);
                user = Activator.CreateInstance<ApplicationUser>();
                user.DisplayName = warframeLoginRequest.email.Split("@")[0];
                user.SteamId = "0";
                user.EmailConfirmed = true;
                await _userStore.SetUserNameAsync(user, warframeLoginRequest.email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, warframeLoginRequest.email, CancellationToken.None);
                await _userManager.CreateAsync(user, upperPassword);
                _createPlayerHandler.Handle(new CreatePlayer() { ApplicationUserId = user.Id, PlatinumGiftAmount = 50 });
                _logger.LogInformation("WarframeLoginHandler => email {email} =>  new user created ", warframeLoginRequest.email);

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
            LoginTrackingItem loginTrackingItem = new LoginTrackingItem()
            {
                ApplicationUserId = user.Id,
                Nonce = newNonce,
                IPAddress = warframeLoginRequest.UserIpAddress,
                LoginTimestamp = DateTimeOffset.Now
            };
            _applicationDbContext.LoginTrackingItems.Add(loginTrackingItem);

            IdentityResult identityResult = null;
            try
            {
                _logger.LogInformation("WarframeLoginHandler => email {email} =>  Updating user login", warframeLoginRequest.email);
                identityResult = await _userManager.UpdateAsync(user);
                _applicationDbContext.SaveChanges();
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
                _logger.LogError("WarframeLoginHandler => email {email} =>  Error while updating user {Errors}", warframeLoginRequest.email, identityResult.Errors.Select(s => s.Description));
            }
            else
            {
                warframeLoginResult.WarframeLoginResultStatus = WarframeLoginResultStatus.Success;

                warframeLoginResult.WarframeLoginResultDetails = new WarframeLoginResultDetails()
                {
                    id = user.Id.ToString(),
                    BuildLabel = _configuration.GetValue<string>("BuildLabel"), 
                    DisplayName = user.DisplayName,
                    NatHash = "127.0.0.1:88",
                    Nonce = user.CurrentNonce,
                    SteamId = "0"
                };
            }

            return warframeLoginResult;
        }

        private int DetermineLoginStreak(DateTimeOffset lastLoginTimestamp, int currentStreak)
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