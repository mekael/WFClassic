using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;

namespace WFClassic.Web.Logic.Stats.Leaderboard
{
    public class GetLeaderboardStatsHandler
    {

        private ApplicationDbContext _applicationDbContext;
        private ILogger<GetLeaderboardStatsHandler> _logger;


        public GetLeaderboardStatsHandler(ApplicationDbContext applicationDbContext,
                                    ILogger<GetLeaderboardStatsHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }


        //GET http://localhost/stats/leaderboard.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=5239627016210914759&steamId=0&field=Kills&before=0&after=10 HTTP/1.1
        // GET http://localhost/stats/leaderboard.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=5239627016210914759&steamId=0&field=Kills&before=4&after=6&pivotAccountId=c64c1e01-34d6-4311-ae40-7baa5eba3016 HTTP/1.1

        public GetLeaderboardStatsResult Handle(GetLeaderboardStats getLeaderboardStats)
        {
            GetLeaderboardStatsResult result = new GetLeaderboardStatsResult();
            var validationResults = new GetLeaderboardStatsValidator().Validate(getLeaderboardStats);

            if (!validationResults.IsValid)
            {
                _logger.LogError("GetLeaderboardStatsHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", getLeaderboardStats.AccountId, getLeaderboardStats.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.GetLeaderboardStatsResultStatus = GetLeaderboardStatsResultStatus.ValidationErrors;
                return result;
            }

            //TODO: store this in cache. 

            List<GetLeaderboardStatsResultItem> topTenKillers = null;
            try
            {
                _logger.LogInformation("GetLeaderboardStatsHandler => accountId {AccountID} nonce {Nonce} =>  Querying for top 10 killers", getLeaderboardStats.AccountId, getLeaderboardStats.Nonce);

                topTenKillers = _applicationDbContext.MetricItems
                                                           .Where(w => w.EventName == "KILL_ENEMY")
                                                           .GroupBy(gb => gb.DisplayName)
                                                           .Select(s => new GetLeaderboardStatsResultItem() { DisplayName = s.Key, rank= 1,  score = s.Sum(s => s.ItemCount.HasValue? s.ItemCount.Value:0) })
                                                           .OrderByDescending(obd => obd.score)
                                                           .Take(10)
                                                           .ToList();

                result.GetLeaderboardStatsResultStatus = GetLeaderboardStatsResultStatus.Success;

                _logger.LogInformation("GetLeaderboardStatsHandler => accountId {AccountID} nonce {Nonce} => Query Complete", getLeaderboardStats.AccountId, getLeaderboardStats.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetLeaderboardStatsHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for killers {Ex}", getLeaderboardStats.AccountId, getLeaderboardStats.Nonce, ex);
                result.GetLeaderboardStatsResultStatus = GetLeaderboardStatsResultStatus.DatabaseErrors;
            }





            //TODO: Deal with the players rank amongst other players
            // add them to the top ten list. 
            // will need to get their displayname from the users table
            if (getLeaderboardStats.PivotAccountId != Guid.Empty)
            {
                _logger.LogError("GetLeaderboardStatsHandler => accountId {AccountID} nonce {Nonce} =>  Pivot not yet implemented", getLeaderboardStats.AccountId, getLeaderboardStats.Nonce);
            }

            result.GetLeaderboardStatsResultJson = new GetLeaderboardStatsResultJson()
            {
                players = topTenKillers
            };




            return result;
        }

    }
}
