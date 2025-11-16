namespace WFClassic.Web.Logic.SessionHandling;

public class WarframeSession
{
    public string HostName { get; set; }
    public string HostIpAddress { get; set; }
    public Guid SessionId { get; set; }
    public Guid HostUserId { get; set; }
    public int BuildId { get; set; }


    public int MinimumNumberOfPlayers { get; set; }
    public int MaximumNumberOfPlayers { get; set; }
    public int NumberOfPrivateSlots { get; set; }
    public int NumberOfFreePublicSlots { get; set; }
    public int NumberOfFreePrivateSlots { get; set; }
    public int ScoreLimit { get; set; }
    public int TimeLimit { get; set; }
    public int GameModeId { get; set; }
    public int RegionId { get; set; }
    public float Difficulty { get; set; }
    public float EloRating { get; set; }
    public bool EnableVoice { get; set; }
    public string MatchType { get; set; }
    public List<string> Maps { get; set; }
    public string OriginalSessionId { get; set; }

}
