using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Logic.SessionHandling;

public class SessionHandler
{

    private readonly ILogger<SessionHandler> _logger;
    private readonly InMemoryLoginTracking _inMemoryLoginTracking;


    public SessionHandler(ILogger<SessionHandler> logger, InMemoryLoginTracking inMemoryLoginTracking)
    {
        this._logger = logger;
        this._inMemoryLoginTracking = inMemoryLoginTracking;
    }


    public AggregateSessionsResult HandleAggregateSessions(AggregateSessionsRequest aggregateSessionsRequest)
    {
        //TODO: add in checks for private sessions
        // and those that are being hosted by your friends / members of your clan. 
        var sessions = this._inMemoryLoginTracking.SessionsListing.Where(w => w.Value.RegionId == aggregateSessionsRequest.RegionId
                                                                             && w.Value.BuildId == aggregateSessionsRequest.BuildId)
                                                                  .Select(s => s.Value);
        return new AggregateSessionsResult()
        {
            Results = sessions.GroupBy(gb => gb.GameModeId).Select(s => new AggregateSessionsResultItem() { GameModeId = s.Key, Count = s.Count() }).ToList()
        };
    }


    public AggregateSessionsResult HandleFindSessions(AggregateSessionsRequest aggregateSessionsRequest)
    {
        //TODO: add in checks for private sessions
        // and those that are being hosted by your friends / members of your clan. 
        var sessions = this._inMemoryLoginTracking.SessionsListing.Where(w => w.Value.RegionId == aggregateSessionsRequest.RegionId
                                                                             && w.Value.BuildId == aggregateSessionsRequest.BuildId)
                                                                  .Select(s => s.Value);
        return new AggregateSessionsResult()
        {
            Results = sessions.GroupBy(gb => gb.GameModeId).Select(s => new AggregateSessionsResultItem() { GameModeId = s.Key, Count = s.Count() }).ToList()
        };
    }


    public HostSessionResponse HandleHostSession(HostSessionRequest hostSessionRequest)
    {
        Guid sessionId = Guid.NewGuid();

        var session = new WarframeSession()
        {
            TimeLimit = hostSessionRequest.TimeLimit,
            BuildId = hostSessionRequest.BuildId,
            SessionId = sessionId,
            Difficulty = hostSessionRequest.Difficulty,
            EnableVoice = hostSessionRequest.EnableVoice,
            GameModeId = hostSessionRequest.GameModeId,
            HostUserId = hostSessionRequest.AccountId,
            HostName = this._inMemoryLoginTracking.LoggedInUserListing[hostSessionRequest.AccountId].DisplayName,
            Maps = hostSessionRequest.Maps,
            MatchType = hostSessionRequest.MatchType,
            MaximumNumberOfPlayers = hostSessionRequest.MaximumNumberOfPlayers,
            MinimumNumberOfPlayers = hostSessionRequest.MinimumNumberOfPlayers,
            NumberOfFreePrivateSlots = hostSessionRequest.NumberOfFreePrivateSlots,
            NumberOfFreePublicSlots = hostSessionRequest.NumberOfFreePublicSlots,
            NumberOfPrivateSlots = hostSessionRequest.NumberOfPrivateSlots,
            RegionId = hostSessionRequest.RegionId,
            ScoreLimit = hostSessionRequest.ScoreLimit,
            HostIpAddress = hostSessionRequest.HostIpAddress
        };
        if (this._inMemoryLoginTracking.SessionsListing.ContainsKey(hostSessionRequest.AccountId))
        {
            this._inMemoryLoginTracking.SessionsListing[hostSessionRequest.AccountId] = session;
        }
        else
        {
            this._inMemoryLoginTracking.SessionsListing.Add(hostSessionRequest.AccountId, session); 
        }

        return new HostSessionResponse() { SessionId = sessionId };
    }
}
