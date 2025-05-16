namespace WFClassic.Web.Logic.Shared.Models
{
    public class WorldStateDate
    {
 
        public WorldStateDate(DateTimeOffset date)
        {
            this.sec = date.ToUnixTimeSeconds();
            this.usec = 0;

        }
        public long sec { get; set; }
        public long usec { get; set; }
    }
}
