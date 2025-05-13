namespace WFClassic.Web.Data.Models
{
    public class Mission : EntityBase
    {
        public Guid PlayerId { get; set; }
        public Player Player { get; set; }
        public string Tag { get; set; }
        public int Completes { get; set; }
        public float BestRatings { get; set; }
    }
}