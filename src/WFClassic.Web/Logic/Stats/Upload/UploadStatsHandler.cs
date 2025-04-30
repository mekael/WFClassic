using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Admin.CheckOnline;
using WFClassic.Web.Logic.Credits.Get;
using WFClassic.Web.Logic.Inventory.Get;

namespace WFClassic.Web.Logic.Stats.Upload
{
    public class UploadStatsHandler
    {

        private ApplicationDbContext _applicationDbContext;
        private ILogger<UploadStatsHandler> _logger;
        private IsUserOnlineQueryHandler _isUserOnlineQueryHandler;


        public UploadStatsHandler(ApplicationDbContext applicationDbContext, 
                                    ILogger<UploadStatsHandler> logger, 
                                    IsUserOnlineQueryHandler isUserOnlineQueryHandler )
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _isUserOnlineQueryHandler = isUserOnlineQueryHandler;
        }

        public UploadStatsResult Handle(UploadStats uploadStats)
        {
            UploadStatsResult result = new UploadStatsResult();
            var validationResults = new UploadStatsValidator().Validate(uploadStats);

            if (!validationResults.IsValid)
            {
                _logger.LogError("UploadStatsHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", uploadStats.AccountId, uploadStats.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.UploadStatsResultStatus = UploadStatsResultStatus.ValidationErrors;
                return result;
            }


            var isLoggedInResult = _isUserOnlineQueryHandler.Handle(new IsUserOnlineQuery(uploadStats.AccountId, uploadStats.Nonce) { });
            if (isLoggedInResult.IsUserOnlineQueryResultStatus != IsUserOnlineQueryResultStatus.IsLoggedIn)
            {
                _logger.LogError("UploadStatsHandler => accountId {AccountID} nonce {Nonce} => User is not currently logged in with current nonce", uploadStats.AccountId, uploadStats.Nonce);
                result.UploadStatsResultStatus = UploadStatsResultStatus.LoginCheckFailure;
                return result;
            }


            List<MetricItem> metricItems = new List<MetricItem>();

            if (uploadStats.StatsObject.Counters != null)
            {
                _logger.LogInformation("UploadStatsHandler => accountId {AccountID} nonce {Nonce} => Found {Count} counter objects", uploadStats.AccountId, uploadStats.Nonce, uploadStats.StatsObject.Counters.Length);

                foreach (var counterStat in uploadStats.StatsObject.Counters)
                {
                    metricItems.Add(new MetricItem()
                    {
                        EventName = counterStat.Event,
                        ItemCount = counterStat.ItemCount,
                        ItemName = counterStat.ItemName,
                        Set = counterStat.Set,
                        ApplicationUserId = uploadStats.AccountId, 
                        AssociatedNonce = uploadStats.Nonce,
                        DisplayName = uploadStats.StatsObject.DisplayName
                    });
                }
            }

            if (uploadStats.StatsObject.Timers != null)
            {
                _logger.LogInformation("UploadStatsHandler => accountId {AccountID} nonce {Nonce} => Found {Count} timer objects", uploadStats.AccountId, uploadStats.Nonce, uploadStats.StatsObject.Timers.Length);

                foreach (var timerStat in uploadStats.StatsObject.Timers)
                {
                    metricItems.Add(new MetricItem()
                    {
                        EventName = timerStat.Event,
                        ItemName = timerStat.ItemName,
                        Seconds = timerStat.Seconds,
                        ApplicationUserId = uploadStats.AccountId,
                        AssociatedNonce = uploadStats.Nonce,
                        DisplayName = uploadStats.StatsObject.DisplayName
                    });
                }
            }

            try 
            {
                _logger.LogInformation("UploadStatsHandler => accountId {AccountID} nonce {Nonce} => Saving stats to db", uploadStats.AccountId, uploadStats.Nonce);
                _applicationDbContext.MetricItems.AddRange(metricItems);
                _applicationDbContext.SaveChanges();
                result.UploadStatsResultStatus = UploadStatsResultStatus.Success;

                _logger.LogInformation("UploadStatsHandler => accountId {AccountID} nonce {Nonce} => ", uploadStats.AccountId, uploadStats.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("UploadStatsHandler => accountId {AccountID} nonce {Nonce} => {Ex}", uploadStats.AccountId, uploadStats.Nonce, ex);
                result.UploadStatsResultStatus = UploadStatsResultStatus.DatabaseErrors;
            }


            return result;
        }
    }
}
