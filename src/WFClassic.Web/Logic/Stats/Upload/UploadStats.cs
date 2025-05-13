using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Stats.Upload
{
    public class UploadStats
    {
        public Guid AccountId { get; set; }

        public long Nonce { get; set; }

        public StatsObject StatsObject { get; set; }
    }

    public class StatsObject
    {
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("counters")]
        public Counter[] Counters { get; set; }

        [JsonPropertyName("timers")]
        public Timer[] Timers { get; set; }

        [JsonPropertyName("events")]
        public object[] Events { get; set; }
    }

    public class Counter
    {
        [JsonPropertyName("event")]
        public string Event { get; set; }

        [JsonPropertyName("counter")]
        public int ItemCount { get; set; }

        [JsonPropertyName("object")]
        public string ItemName { get; set; }

        [JsonPropertyName("set")]
        public bool? Set { get; set; }
    }

    public class Timer
    {
        [JsonPropertyName("event")]
        public string Event { get; set; }

        [JsonPropertyName("object")]
        public string ItemName { get; set; }

        [JsonPropertyName("seconds")]
        public float Seconds { get; set; }
    }
}