 
namespace WFClassic.Web.Logic.Foundry.Rush
{
    public class RushRecipeResult
    {
        public RushRecipeResultStatus RushRecipeResultStatus { get; set; }
        public string BuiltItem { get; set; }

    }

   

    public enum RushRecipeResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}
