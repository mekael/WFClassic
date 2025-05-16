namespace WFClassic.Web.Data.Models
{
    public class AlertEnemyConfiguration : EntityBase
    {
        public Guid AlertConfigurationId { get; set; }
        public AlertConfiguration AlertConfiguration { get; set; }
        public string EnemyId { get; set; } // known as agent 
        public float Probability { get; set; }
        public int MaxSimultaneous { get; set; }
        public int Tier { get; set; }
    }
}

 