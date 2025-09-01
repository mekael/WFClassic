using System.Text.Json.Serialization;

using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Exp.Training
{
    public class AddLevelBasedOnTrainingResult
    {
        [JsonPropertyName("NewLevel")]
        public int NewLevel { get; set; }

        [JsonPropertyName("NewTrainingDate")]
        public MongoDate NewTrainingDate { get; set; }

        [JsonIgnore]
        public AddLevelBasedOnTrainingResultStatus AddLevelBasedOnTrainingResultStatus { get; set; }
    }

    public enum AddLevelBasedOnTrainingResultStatus
    {
        Success,
        ValidationErrors,
        DatabaseErrors
    }
}