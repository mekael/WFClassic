

using System.Text.Json.Serialization;

using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Clans.Get
{
    public class GetGuildResult
    {
        public GetGuildResultStatus GetGuildResultStatus { get; set; }

        public GetGuildResultJson GetGuildResultJson { get; set; }

    }


    public enum GetGuildResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }

    public class GetGuildResultJson
    {

        [JsonPropertyName("_id")]
        public MongoId _id { get; set; }

        [JsonPropertyName("Tier")]
        public int Tier { get; set; } = 2;  

        [JsonPropertyName("Members")]
        public List<GetGuildResultMemberJson> Members { get; set; }

        [JsonPropertyName("Ranks")]
        public List<GetGuildResultRanksJson>Ranks { get; set; }
    }

    public class GetGuildResultRanksJson
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Permissions")]
        public int Permissions { get; set; }

    }

    public class GetGuildResultMemberJson
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        
        [JsonPropertyName("Rank")]
        public int Rank { get; set; }

        [JsonPropertyName("_id")]
        public MongoId _id { get; set; }
        [JsonPropertyName("Status")]
        public int Status { get; set; }
    }
}