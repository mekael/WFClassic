using System.Text.Json.Serialization;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Foundry.Start
{
    public class StartRecipeBuildResult
    {
        public StartRecipeBuildResultStatus StartRecipeBuildResultStatus { get; set; }

    }

   

    public enum StartRecipeBuildResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}
