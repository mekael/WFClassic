namespace WFClassic.Web.Data.Models
{
    public class TauntHistoryItem : EntityBase
    {
        public Guid PlayerId { get; set; }
        public Player Player { get; set; }
        public string Node { get; set; }    
    }
}
