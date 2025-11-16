using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.SessionHandling;

public class FindSessionsResultJson
{
    public List<FindSessionsResultItemJson> Results { get; set; }
}

public class FindSessionsResultItemJson
{
    [JsonPropertyName("hostName")]
    public string HostUserName { get; set; } // host's username

    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }

    [JsonPropertyName("hostId")]
    public Guid HostUserId { get; set; } // host's userId
    
    [JsonPropertyName("originalSessionId")]
    public string OriginalSessionId { get; set; }

    [JsonPropertyName("maxPlayers")]
    public int MaximumNumberOfPlayers { get; set; }

    [JsonPropertyName("minPlayers")]
    public int MinimumNumberOfPlayers { get; set; }

    [JsonPropertyName("privateSlots")]
    public int NumberOfPrivateSlots { get; set; }

    [JsonPropertyName("scoreLimit")]
    public int ScoreLimit { get; set; }

    [JsonPropertyName("timeLimit")]
    public int TimeLimit { get; set; }

    [JsonPropertyName("gameModeId")]
    public int GameModeId { get; set; }

    [JsonPropertyName("difficulty")]
    public float Difficulty { get; set; }

    [JsonPropertyName("enableVoice")]
    public bool EnableVoice { get; set; }

    [JsonPropertyName("matchType")]
    public string MatchType { get; set; }

    [JsonPropertyName("maps")]
    public List<string> Maps { get; set; }



    [JsonPropertyName("freePublic")]
    public int NumberOfFreePublicSlots { get; set; }

    [JsonPropertyName("freePrivate")]
    public int NumberOfFreePrivateSlots { get; set; }

    [JsonPropertyName("eloRating")]
    public float EloRating { get; set; }

    [JsonPropertyName("strictNAT")]
    public int StrictNAT { get; set; }

}

public class FindSessionsRequest
{
    [JsonIgnore()]
    public Guid AccountId { get; set; }
    [JsonPropertyName("buildId")]
    public int BuildId { get; set; }

    [JsonPropertyName("gameModeId")]
    public int GameModeId { get; set; }

    [JsonPropertyName("regionId")] 
    public int RegionId { get; set; }
}
