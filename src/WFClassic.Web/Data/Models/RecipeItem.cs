namespace WFClassic.Web.Data.Models
{
    public class RecipeItem : EntityBase
    {
        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public string ItemName { get; set; }
        public string PrettyName { get; set; }
        public string ItemCountNeeded { get; set; }
    }
}
