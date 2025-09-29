namespace WFClassic.Web.Logic.Sessions.Find;

public class FindSessionsResult
{
    public List<FindSessionsResultJson> Results { get; set; }
}

public class FindSessionsResultJson
{
    public string hostName { get; set; } // host's username
    public Guid sessionId { get; set; }
    public Guid hostId { get; set; } // host's userId
    public int maxPlayers { get; set; }
    public int minPlayers { get; set; }
    public int privateSlots { get; set; }
    public int scoreLimit { get; set; }
    public int timeLimit { get; set; }
    public long gameModeId { get; set; }
    public int difficulty { get; set; }
    public bool enableVoice { get; set; }
    public string matchType { get; set; }
    public int freePublic { get; set; }
    public int freePrivate { get; set; }
    public float eloRating { get; set; }
    public List<string> maps { get; set; } = new List<string>();
    public Guid originalSessionId { get; set; }
    public string strictNAT { get; set; }


}
