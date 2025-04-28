
using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Shared.Models
{
    public class MongoDate
    {

        [JsonPropertyName("$date")]
        public MongoLongDate MongoLongDate { get; set; }

        public MongoDate(DateTime date)
        {
            MongoLongDate = new MongoLongDate() { NumberLong = new DateTimeOffset(date).ToUnixTimeMilliseconds().ToString() };
        }
    }

    public class MongoLongDate
    {
        [JsonPropertyName("$numberLong")]
        public string NumberLong { get; set; }
    }
}
