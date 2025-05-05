namespace WFClassic.Web.Logic.Taunt
{
    public class AddTauntResult
    {
        public AddTauntResultStatus  AddTauntResultStatus { get; set; }
    }

    public enum AddTauntResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success
    }
}
