using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Universe.GetState
{
    public class GetWorldStateHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<GetWorldStateHandler> _logger;
        private readonly IConfiguration _configuration;

        public GetWorldStateHandler(ApplicationDbContext applicationDbContext,
                                    ILogger<GetWorldStateHandler> logger, 
                                    IConfiguration configuration)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _configuration = configuration;
        }

        //GET http://localhost/stats/leaderboard.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=5239627016210914759&steamId=0&field=Kills&before=0&after=10 HTTP/1.1
        // GET http://localhost/stats/leaderboard.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=5239627016210914759&steamId=0&field=Kills&before=4&after=6&pivotAccountId=c64c1e01-34d6-4311-ae40-7baa5eba3016 HTTP/1.1

        public GetWorldStateResult Handle(GetWorldState getWorldState)
        {
            GetWorldStateResult result = new GetWorldStateResult();
            var validationResults = new GetWorldStateValidator().Validate(getWorldState);

            if (!validationResults.IsValid)
            {
                _logger.LogError("GetWorldStateHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", getWorldState.AccountId, getWorldState.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.GetWorldStateResultStatus = GetWorldStateResultStatus.ValidationErrors;
                return result;
            }

            //TODO: store this in cache.?

            List<WorldStateEventMessage> worldStateEventMessages = null;
            List<AlertConfiguration> worldStateAlerts = null;
            try
            {
                _logger.LogInformation("GetWorldStateHandler => accountId {AccountID} nonce {Nonce} =>   ", getWorldState.AccountId, getWorldState.Nonce);

                //Get all events
                // get the alerts
                worldStateEventMessages = _applicationDbContext.WorldStateEventMessages.Where(w => w.IsActive).ToList();
                worldStateAlerts = _applicationDbContext.AlertConfigurations
                                                                         .Include(i=> i.AlertEnemyConfigurations)
                                                                         .Include(i=> i.AlertRewardConfigurations)
                                                                         .Where(w => w.IsActive)
                                                                         .ToList();

                result.GetWorldStateResultStatus = GetWorldStateResultStatus.Success;

                _logger.LogInformation("GetWorldStateHandler => accountId {AccountID} nonce {Nonce} => Query Complete", getWorldState.AccountId, getWorldState.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetWorldStateHandler => accountId {AccountID} nonce {Nonce} =>  {Ex}", getWorldState.AccountId, getWorldState.Nonce, ex);
                result.GetWorldStateResultStatus = GetWorldStateResultStatus.DatabaseErrors;
            }

            try 
            {
                _logger.LogInformation("GetWorldStateHandler => accountId {AccountID} nonce {Nonce} =>   ", getWorldState.AccountId, getWorldState.Nonce);
                result.GetWorldStateResultJson = GetWorldStateMapper.Map(worldStateEventMessages, worldStateAlerts, _configuration.GetValue<string>("BuildLabel"));
                _logger.LogInformation("GetWorldStateHandler => accountId {AccountID} nonce {Nonce} =>   ", getWorldState.AccountId, getWorldState.Nonce);
                result.GetWorldStateResultStatus = GetWorldStateResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetWorldStateHandler => accountId {AccountID} nonce {Nonce} =>  {Ex}", getWorldState.AccountId, getWorldState.Nonce, ex);
                result.GetWorldStateResultStatus = GetWorldStateResultStatus.MappingErrors;

            }


            return result;
        }
    }
}