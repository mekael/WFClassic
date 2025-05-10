using System.Text.Json.Serialization;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Foundry.Claim
{
    public class ClaimCompletedRecipeResult
    {
        public ClaimCompletedRecipeResultStatus ClaimCompletedRecipeResultStatus { get; set; }
        public string BuiltItem { get; set; }

    }

   

    public enum ClaimCompletedRecipeResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}
