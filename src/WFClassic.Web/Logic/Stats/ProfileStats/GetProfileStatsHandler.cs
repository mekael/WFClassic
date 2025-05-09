using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Stats.ProfileStats
{
    public class GetProfileStatsHandler
    {

        private ApplicationDbContext _applicationDbContext;
        private ILogger<GetProfileStatsHandler> _logger;


        public GetProfileStatsHandler(ApplicationDbContext applicationDbContext,
                                    ILogger<GetProfileStatsHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }


        //GET http://localhost/stats/leaderboard.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=5239627016210914759&steamId=0&field=Kills&before=0&after=10 HTTP/1.1
        // GET http://localhost/stats/leaderboard.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=5239627016210914759&steamId=0&field=Kills&before=4&after=6&pivotAccountId=c64c1e01-34d6-4311-ae40-7baa5eba3016 HTTP/1.1

        public GetProfileStatsResult Handle(GetProfileStats getProfileStats)
        {
            GetProfileStatsResult result = new GetProfileStatsResult();
            var validationResults = new GetProfileStatsValidator().Validate(getProfileStats);

            if (!validationResults.IsValid)
            {
                _logger.LogError("GetProfileStatsHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", getProfileStats.AccountId, getProfileStats.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.GetProfileStatsResultsStatus = GetProfileStatsResultsStatus.ValidationErrors;
                return result;
            }

            //TODO: store this in cache. 
            List<MetricItem> metricItems = null;
            try
            {
                _logger.LogInformation("GetProfileStatsHandler => accountId {AccountID} nonce {Nonce} =>   ", getProfileStats.AccountId, getProfileStats.Nonce);

                metricItems = _applicationDbContext.MetricItems.Where(w => w.ApplicationUserId == getProfileStats.LookupId).ToList();
                _logger.LogInformation("GetProfileStatsHandler => accountId {AccountID} nonce {Nonce} => Query Complete", getProfileStats.AccountId, getProfileStats.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetProfileStatsHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for killers {Ex}", getProfileStats.AccountId, getProfileStats.Nonce, ex);
                result.GetProfileStatsResultsStatus = GetProfileStatsResultsStatus.DatabaseErrors;
                return result;
            }


            try {
                result.ProfileStatsItem = new ProfileStatsItem()
                {

                    CiphersFailed = metricItems.Where(w => w.EventName == "CIPHER" && w.ItemName == "0").Sum(s => s.ItemCount.HasValue ? s.ItemCount.Value : 0),
                    CiphersSolved = metricItems.Where(w => w.EventName == "CIPHER" && w.ItemName == "1").Sum(s => s.ItemCount.HasValue ? s.ItemCount.Value : 0),
                    CipherTime = metricItems.Where(w => w.EventName == "CIPHER_TIME").Sum(s => s.Seconds.HasValue ? s.Seconds.Value : 0),
                    TimePlayedSec = metricItems.Where(w => w.EventName == "MISSION_TIME").Sum(s => s.Seconds.HasValue ? s.Seconds.Value : 0),

                    //TODO: check to see if these make sense? 
                    MissionsCompleted = metricItems.Where(w => w.EventName == "MISSION_COMPLETE" && w.ItemName == "GS_SUCCESS").Sum(s => s.ItemCount.HasValue ? s.ItemCount.Value : 0),
                    MissionsFailed = metricItems.Where(w => w.EventName == "MISSION_COMPLETE" && w.ItemName == "GS_FAILURE").Sum(s => s.ItemCount.HasValue ? s.ItemCount.Value : 0),
                    MissionsInterrupted = metricItems.Where(w => w.EventName == "MISSION_COMPLETE" && w.ItemName == "GS_INTERRUPTED").Sum(s => s.ItemCount.HasValue ? s.ItemCount.Value : 0),
                    MissionsDumped = metricItems.Where(w => w.EventName == "MISSION_COMPLETE" && w.ItemName == "GS_DUMPED").Sum(s => s.ItemCount.HasValue ? s.ItemCount.Value : 0),
                    MissionsQuit = metricItems.Where(w => w.EventName == "MISSION_COMPLETE" && w.ItemName == "GS_QUIT").Sum(s => s.ItemCount.HasValue ? s.ItemCount.Value : 0),
                    ReviveCount = metricItems.Where(w => w.EventName == "REVIVE_BUDDY").Sum(s => s.ItemCount.HasValue ? s.ItemCount.Value : 0),
                    HealCount = metricItems.Where(w => w.EventName == "HEAL_BUDDY").Sum(s => s.ItemCount.HasValue ? s.ItemCount.Value : 0),
                    //TODO: once we determine how the rest of the other data points are represented, this will need to be it's own function / for loop. 
                    Enemies = metricItems.Where(w => w.EventName == "KILL_ENEMY" && w.ItemName.StartsWith("/Lotus/Types/Enemies/"))
                             .GroupBy(gb => gb.ItemName)
                             .Select(s => new Enemy() { type = s.Key, deaths = s.Sum(si => si.ItemCount.HasValue ? si.ItemCount.Value : 0) })
                             .ToList()

                }

        ;

                result.GetProfileStatsResultsStatus = GetProfileStatsResultsStatus.Success;
            
            }
            catch(Exception ex)
            {
                _logger.LogError("GetProfileStatsHandler => accountId {AccountID} nonce {Nonce} =>  Mapping Errors {Ex}", getProfileStats.AccountId, getProfileStats.Nonce, ex);
                result.GetProfileStatsResultsStatus = GetProfileStatsResultsStatus.MappingErrors;
            }






            return result;
        }



    }
}

/*
        public long Rating { get; set; }
        public long Rank { get; set; }

        public Enemy[] Enemies { get; set; }
 
 */
