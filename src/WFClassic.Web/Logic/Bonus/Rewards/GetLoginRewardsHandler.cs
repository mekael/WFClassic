using FluentValidation;
using Microsoft.AspNetCore.Identity;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Bonus.Rewards
{
    public class GetLoginRewardsHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<GetLoginRewardsHandler> _logger;
        private UserManager<ApplicationUser> _userManager;

        public GetLoginRewardsHandler(ApplicationDbContext applicationDbContext, ILogger<GetLoginRewardsHandler> logger, UserManager<ApplicationUser> userManager)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<GetLoginRewardsResult> HandleAsync(GetLoginRewards getLoginRewards)
        {
            GetLoginRewardsResult result = new GetLoginRewardsResult();
            var validationResults = new GetLoginRewardsValidator().Validate(getLoginRewards);

            if (!validationResults.IsValid)
            {
                _logger.LogError("GetLoginRewardsHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", getLoginRewards.AccountId, getLoginRewards.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.GetLoginRewardsResultStatus = GetLoginRewardsResultStatus.ValidationErrors;
                return result;
            }

            ApplicationUser user = null;
            List<DailyRewardDefinition> dailyRewardDefinitions = null;
            List<DateTimeOffset> loginTimestamps = null;

            try
            {
                _logger.LogInformation("GetLoginRewardsHandler => accountId {AccountID} nonce {Nonce} => Starting Query for player", getLoginRewards.AccountId, getLoginRewards.Nonce);
                loginTimestamps = _applicationDbContext.LoginTrackingItems.Where(w => w.ApplicationUserId == getLoginRewards.AccountId).Select(s => s.LoginTimestamp).ToList();

                user = await _userManager.FindByIdAsync(getLoginRewards.AccountId.ToString());
                dailyRewardDefinitions = _applicationDbContext.DailyRewardDefinitions.ToList();
                _logger.LogInformation("GetLoginRewardsHandler => accountId {AccountID} nonce {Nonce} => Query Complete for player ", getLoginRewards.AccountId, getLoginRewards.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetLoginRewardsHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", getLoginRewards.AccountId, getLoginRewards.Nonce, ex);
                result.GetLoginRewardsResultStatus = GetLoginRewardsResultStatus.DatabaseErrors;
                return result;
            }

            if (loginTimestamps.Count(w => w.Date == DateTime.Today) > 1)
            {
                // we've already provided the reward
                _logger.LogInformation("GetLoginRewardsHandler => accountId {AccountID} nonce {Nonce} => Login reward already assigned", getLoginRewards.AccountId, getLoginRewards.Nonce);
                result.GetLoginRewardsResultStatus = GetLoginRewardsResultStatus.AlreadyProvided;
                return result;
            }

            try
            {
                var rand = new Random().Next(1, 101);
                var assignedReward = dailyRewardDefinitions.Where(w => w.StreakStartDate <= user.LoginStreak
                                                                           && w.StreakEndDate >= user.LoginStreak
                                                                           && w.RandLowerBound <= rand
                                                                           && w.RandUpperBound >= rand)
                                                               .First();
                _logger.LogInformation("GetLoginRewardsHandler => accountId {AccountID} nonce {Nonce} => Providing reward {Id} to player", getLoginRewards.AccountId, getLoginRewards.Nonce, assignedReward.Id);

                result.GetLoginRewardsResultReturnJson = new GetLoginRewardsResultReturnJson()
                {
                    Rewards = new List<Reward>()
                {
                    new Reward()
                    {
                        Amount= assignedReward.Amount,
                        Category=assignedReward.ProductCategory,
                        Icon = assignedReward.Icon,
                        ItemType = assignedReward.ItemType,
                        ProductCategory = assignedReward.ProductCategory,
                        Rarity = assignedReward.Rarity,
                        RewardType = assignedReward.RewardType,
                        Tier     = assignedReward.Tier
                    }
                }
                };
                result.GetLoginRewardsResultStatus = GetLoginRewardsResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetLoginRewardsHandler => accountId {AccountID} nonce {Nonce} => Exception while mapping return object : {Ex}", getLoginRewards.AccountId, getLoginRewards.Nonce, ex);
                result.GetLoginRewardsResultStatus = GetLoginRewardsResultStatus.MappingFailure;
            }

            return result;
        }
    }
}