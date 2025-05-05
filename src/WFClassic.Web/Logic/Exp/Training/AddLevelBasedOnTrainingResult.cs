using Newtonsoft.Json;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Exp.Training
{
    public class AddLevelBasedOnTrainingResult
    {

        [JsonProperty("NewLevel")]
        public int NewLevel { get; set; }

        [JsonProperty("NewTrainingDate")]
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
