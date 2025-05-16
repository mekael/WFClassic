namespace WFClassic.Web.Data.Models
{
    public class WorldStateEventMessage : EntityBase
    {
        public string Message { get; set; }
        public int MessageType { get; set; } = 1;
        public string Property { get; set; }
        public DateTimeOffset MessageDate { get; set; }
        public DateTimeOffset? MessageExpirationDate { get; set; }
        public bool IsActive { get; set; }
    }
}


/*
             ""_id"": {
                ""$id"": ""5187e9393f9a5b131c66f528""
            },
            ""Msg"": ""Update 9.8.5"",
            ""Prop"": ""index.php?/topic/104304-hotfix-985/"",
            ""Date"": {
                ""sec"": 1378765369,
                ""usec"": 149000
            }
 */