using Newtonsoft.Json;

namespace WFClassic.Web.Logic.Exp.Training
{
    public class AddLevelBasedOnTraining
    {
        [JsonProperty("accountId")]
        public Guid AccountId { get; set; }

        [JsonProperty("nonce")]
        public long Nonce { get; set; }

        [JsonProperty("numLevelsGained")]
        public int NumLevelsGained { get; set; }
    }
}