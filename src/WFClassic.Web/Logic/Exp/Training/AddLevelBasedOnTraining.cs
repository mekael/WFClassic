using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Exp.Training
{
    public class AddLevelBasedOnTraining
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }

        [JsonPropertyName("numLevelsGained")]
        public int NumLevelsGained { get; set; }
    }
}