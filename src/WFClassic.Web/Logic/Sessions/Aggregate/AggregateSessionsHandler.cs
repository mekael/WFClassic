using WFClassic.Web.Data;
using WFClassic.Web.Logic.Credits.Get;

namespace WFClassic.Web.Logic.Sessions.Aggregate
{
    public class AggregateSessionsHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<AggregateSessionsHandler> _logger;
        private readonly GetCreditsHandler _getCreditsHandler;

        public AggregateSessionsHandler(ApplicationDbContext applicationDbContext, ILogger<AggregateSessionsHandler> logger, GetCreditsHandler getCreditsHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _getCreditsHandler = getCreditsHandler;
        }

        public AggregateSessionsResult Handle(AggregateSessions AggregateSessions)
        {
            AggregateSessionsResult result = new AggregateSessionsResult();
            var validationResults = new AggregateSessionsValidator().Validate(AggregateSessions);

            if (!validationResults.IsValid)
            {
                _logger.LogError("AggregateSessionsHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", AggregateSessions.AccountId, AggregateSessions.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.AggregateSessionsResultStatus = AggregateSessionsResultStatus.ValidationErrors;
                return result;
            }

            // get all sessions for the given region from the memorycache. 
            // 
            return result;
        }
    }
}