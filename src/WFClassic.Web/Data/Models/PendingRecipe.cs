namespace WFClassic.Web.Data.Models
{
    public class PendingRecipe : EntityBase
    {
        public Guid PlayerId { get; set; }
        public Player Player { get; set; }
        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public DateTimeOffset StartingTime { get; set; }
        public DateTimeOffset EndingTime { get; set; }
    }
}