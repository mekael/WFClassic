using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class Recipe : EntityBase
    {
        public InternalInventoryItemType InternalInventoryItemType { get; set; }
        public string ResultItemName { get; set; }
        public string ResultItemPrettyName { get; set; }

        public string RecipeItemName { get; set; }
        public string RecipeItemPrettyName { get; set; }

        public long BuildTimeInMinutes { get; set; }
        public long PriceInStandardCredits { get; set; }
        public long SkipBuildPriceInPlatinum { get; set; }

        public List<RecipeItem> RecipeComponentItems { get; set; }
    }
}