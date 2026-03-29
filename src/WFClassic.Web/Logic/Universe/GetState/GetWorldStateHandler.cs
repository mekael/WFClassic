using Microsoft.EntityFrameworkCore;

using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Logic.Universe.GetState
{
    public class GetWorldStateHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<GetWorldStateHandler> _logger;
         private readonly ServerConfiguration _serverConfiguration;

        public GetWorldStateHandler(ApplicationDbContext applicationDbContext,ILogger<GetWorldStateHandler> logger,
                                    ServerConfiguration serverConfiguration)
        {
            this._applicationDbContext = applicationDbContext;
            this._logger = logger;
            this._serverConfiguration=serverConfiguration;
        }
 
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
            List<OperationConfiguration> operationConfigurations = null;
            try
            {
                _logger.LogInformation("GetWorldStateHandler => accountId {AccountID} nonce {Nonce} =>   ", getWorldState.AccountId, getWorldState.Nonce);

                //Get all events
                // get the alerts
                worldStateEventMessages = _applicationDbContext.WorldStateEventMessages.Where(w => w.IsActive).ToList();
                worldStateAlerts = _applicationDbContext.AlertConfigurations.AsSplitQuery()
                                                                         .Include(i => i.AlertEnemyConfigurations)
                                                                         .Include(i => i.AlertRewardConfigurations)
                                                                         .Where(w => w.IsActive)
                                                                         .ToList();

                operationConfigurations = this._applicationDbContext.OperationConfigurations.Where(w => w.IsActive).ToList();

                _logger.LogInformation("GetWorldStateHandler => accountId {AccountID} nonce {Nonce} => Query Complete", getWorldState.AccountId, getWorldState.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetWorldStateHandler => accountId {AccountID} nonce {Nonce} => Exception while attempting to get worldstate definitions  {Ex}", getWorldState.AccountId, getWorldState.Nonce, ex);
                result.GetWorldStateResultStatus = GetWorldStateResultStatus.DatabaseErrors;
            }

            try
            {
                _logger.LogInformation("GetWorldStateHandler => accountId {AccountID} nonce {Nonce} =>   ", getWorldState.AccountId, getWorldState.Nonce);
                result.GetWorldStateResultJson = GetWorldStateMapper.Map(worldStateEventMessages, worldStateAlerts,operationConfigurations, getWorldState.buildLabel ?? this._serverConfiguration.BuildLabel );
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