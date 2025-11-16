using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.SessionHandling;
public class HostSessionRequest
{
    [JsonIgnore()]
    public Guid AccountId { get; set; }

    [JsonIgnore()]
    public long Nonce { get; set; }

    [JsonIgnore()]
    public string HostIpAddress { get; set; }


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

    [JsonPropertyName("regionId")]
    public int RegionId { get; set; }

    [JsonPropertyName("difficulty")]
    public float Difficulty { get; set; }

    [JsonPropertyName("enableVoice")]
    public bool EnableVoice { get; set; }

    [JsonPropertyName("matchType")]
    public string MatchType { get; set; }

    [JsonPropertyName("maps")]
    public List<string> Maps { get; set; }

    [JsonPropertyName("originalSessionId")]
    public string OriginalSessionId { get; set; }

    [JsonPropertyName("buildId")]
    public int BuildId { get; set; }

    [JsonPropertyName("freePublic")]
    public int NumberOfFreePublicSlots { get; set; }

    [JsonPropertyName("freePrivate")]
    public int NumberOfFreePrivateSlots { get; set; }
}

public class HostSessionResponse
{
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }
}
