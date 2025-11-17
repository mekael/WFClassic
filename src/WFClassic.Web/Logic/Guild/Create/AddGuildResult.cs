

namespace WFClassic.Web.Logic.Clans.Create
{
    public class AddGuildResult
    {
        public AddGuildResultStatus AddGuildResultStatus { get; set; }

    }


    public enum AddGuildResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}