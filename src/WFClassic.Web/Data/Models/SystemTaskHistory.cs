using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class SystemTaskHistory : EntityBase
    {
        public SystemTaskType SystemTaskType { get; set; }
        public bool TaskWasSuccessful { get; set; }
        public string ReasonForTaskExecution { get; set; }
        public DateTimeOffset TaskExecutionTimestamp { get; set; }
    }
}
