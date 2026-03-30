using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Logic.SessionHandling;

public class SessionHandler
{

    private readonly InMemoryLoginTracking _inMemoryLoginTracking;
    private  Dictionary<string, WarframeSession> _sessionsListing;


    public SessionHandler( InMemoryLoginTracking inMemoryLoginTracking)
    {
        this._inMemoryLoginTracking = inMemoryLoginTracking;
        this._sessionsListing = new Dictionary<string, WarframeSession>();
    }


    public AggregateSessionsResult HandleAggregateSessions(AggregateSessionsRequest aggregateSessionsRequest)
    {
        //TODO: add in checks for private sessions
        // and those that are being hosted by your friends / members of your clan. 
        var sessions = this._sessionsListing.Where(w => w.Value.RegionId == aggregateSessionsRequest.RegionId
                                                                             && w.Value.BuildId == aggregateSessionsRequest.BuildId
                                                                             && w.Value.HostUserId != aggregateSessionsRequest.AccountId)
                                                                  .Select(s => s.Value);
        return new AggregateSessionsResult()
        {
            Results = sessions.GroupBy(gb => gb.GameModeId).Select(s => new AggregateSessionsResultItem() { GameModeId = s.Key, Count = s.Count() }).ToList()
        };
    }


    public bool HandleDeleteSession(string sessionId, Guid accountId)
    {
        if (this._sessionsListing.ContainsKey(sessionId) && this._sessionsListing[sessionId].HostUserId == accountId)
        {
            return this._sessionsListing.Remove(sessionId);
        }
        return false;
    }

    public FindSessionsResultJson HandleFindSessions(FindSessionsRequest findSessionsRequest)
    {


        IEnumerable<WarframeSession> sessions = null;
        //TODO: add in checks for private sessions
        // and those that are being hosted by your friends / members of your clan. 

        if (!string.IsNullOrWhiteSpace(findSessionsRequest.OriginalSessionId))
        {
            sessions = this._sessionsListing.Where(w => w.Key == findSessionsRequest.OriginalSessionId).Select(s => s.Value);
        }
        else
        {
            sessions = this._sessionsListing.Where(w =>  w.Value.RegionId == findSessionsRequest.RegionId
                                                        && w.Value.BuildId == findSessionsRequest.BuildId
                                                        && w.Value.RegionId == findSessionsRequest.RegionId )
                                            .Select(s => s.Value);
        }


        return new FindSessionsResultJson()
        {
            Sessions = sessions.Select(s => new FindSessionsResultItemJson()
            {
                Difficulty = s.Difficulty,
                HostUserId = s.HostUserId,
                EloRating = s.EloRating,
                EnableVoice = s.EnableVoice,
                GameModeId = s.GameModeId,
                HostUserName = s.HostName,
                Maps = s.Maps,
                MatchType = s.MatchType,
                MaximumNumberOfPlayers = s.MaximumNumberOfPlayers,
                MinimumNumberOfPlayers = s.MinimumNumberOfPlayers,
                NumberOfFreePrivateSlots = s.NumberOfFreePrivateSlots,
                NumberOfFreePublicSlots = s.NumberOfFreePublicSlots,
                NumberOfPrivateSlots = s.NumberOfPrivateSlots,
                OriginalSessionId = s.OriginalSessionId,
                ScoreLimit = s.ScoreLimit,
                SessionId = s.SessionId,
                StrictNAT = s.StrictNAT,
                TimeLimit = s.TimeLimit,

            }).ToList()
        };

    }


    public HostSessionResponse HandleHostSession(HostSessionRequest hostSessionRequest)
    {
        string sessionId = GenerateNewSessionId();

        var session = new WarframeSession()
        {
            TimeLimit = hostSessionRequest.TimeLimit,
            BuildId = hostSessionRequest.BuildId,
            SessionId = sessionId,
            Difficulty = hostSessionRequest.Difficulty,
            EnableVoice = hostSessionRequest.EnableVoice,
            GameModeId = hostSessionRequest.GameModeId,
            HostUserId = hostSessionRequest.AccountId,
            HostName = this._inMemoryLoginTracking.GetUser(hostSessionRequest.AccountId).DisplayName,
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

        if (this._sessionsListing.ContainsKey(sessionId))
        {
            this._sessionsListing[sessionId] = session;
        }
        else
        {
            this._sessionsListing.Add(sessionId, session);
        }

        return new HostSessionResponse() { SessionId = sessionId };
    }

    private string GenerateNewSessionId()
    {
        string sessionId = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 24);
        while (this._sessionsListing.ContainsKey(sessionId))
        {
            sessionId = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 24);
        }
        return sessionId;
    }
}
