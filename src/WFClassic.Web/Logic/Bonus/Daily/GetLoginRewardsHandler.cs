using FluentValidation;
using Microsoft.AspNetCore.Identity;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Bonus.Daily
{
    public class GetDailyMissionBonusHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<GetDailyMissionBonusHandler> _logger;
        private UserManager<ApplicationUser> _userManager;

        public GetDailyMissionBonusHandler(ApplicationDbContext applicationDbContext, ILogger<GetDailyMissionBonusHandler> logger, UserManager<ApplicationUser> userManager)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _userManager = userManager;
        }

        public   GetDailyMissionBonusResult Handle(GetDailyMissionBonus GetDailyMissionBonus)
        {
            GetDailyMissionBonusResult result = new GetDailyMissionBonusResult();
            var validationResults = new GetDailyMissionBonusValidator().Validate(GetDailyMissionBonus);

            if (!validationResults.IsValid)
            {
                _logger.LogError("GetDailyMissionBonusHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", GetDailyMissionBonus.AccountId, GetDailyMissionBonus.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.GetDailyMissionBonusResultStatus = GetDailyMissionBonusResultStatus.ValidationErrors;
                return result;
            }



 
            DateTimeOffset? lastMissionCompletionDate = null;

            try
            {
                _logger.LogInformation("GetDailyMissionBonusHandler => accountId {AccountID} nonce {Nonce} => Starting query for metric item", GetDailyMissionBonus.AccountId, GetDailyMissionBonus.Nonce);

                lastMissionCompletionDate = _applicationDbContext.MetricItems.Where(w => w.ApplicationUserId == GetDailyMissionBonus.AccountId
                                                         && w.EventName == "MISSION_COMPLETE"
                                                         && w.ItemName == "GS_SUCCESS")
                                                                            .Select(s=> s.CreationTimestamp)
                                                                            .ToList()
                                                                            .OrderByDescending(obd=> obd)
                                                                            .FirstOrDefault() ;
                _logger.LogInformation("GetDailyMissionBonusHandler => accountId {AccountID} nonce {Nonce} => Query Complete for metric item ", GetDailyMissionBonus.AccountId, GetDailyMissionBonus.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetDailyMissionBonusHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for metric : {Ex}", GetDailyMissionBonus.AccountId, GetDailyMissionBonus.Nonce, ex);
                result.GetDailyMissionBonusResultStatus = GetDailyMissionBonusResultStatus.DatabaseErrors;
                return result;
            }

            result.GetDailyMissionBonusResultReturnJson = new GetDailyMissionBonusResultReturnJson()
            {
                DailyMissionBonus = lastMissionCompletionDate.HasValue && lastMissionCompletionDate.Value.Date == DateTime.Today ? 0 : 1
            } ;
            result.GetDailyMissionBonusResultStatus = GetDailyMissionBonusResultStatus.Success;
            return result;
        }
    }
}