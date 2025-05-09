using System.Text.Json.Serialization;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Foundry.Pending
{
    public class CheckPendingRecipesResult
    {
        public CheckPendingRecipesResultStatus CheckPendingRecipesResultStatus { get; set; }
        public JsonCheckPendingRecipesResult JsonCheckPendingRecipesResult { get; set; }


    }

    public class JsonCheckPendingRecipesResult
    {
        [JsonPropertyName("PendingRecipes")]
        public List<JsonCheckPendingRecipesResultItem> PendingRecipes { get; set; }
    }

    public class JsonCheckPendingRecipesResultItem
    {
        [JsonPropertyName("PendingRecipes")]
        public string ItemType { get; set; }

        [JsonPropertyName("SecondsRemaining")]
        public long SecondsRemaining { get; set; }
    }

    public enum CheckPendingRecipesResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}
