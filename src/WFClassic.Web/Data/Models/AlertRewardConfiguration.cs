using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class AlertRewardConfiguration : EntityBase
    {

        public Guid AlertConfigurationId { get; set; }
        public AlertConfiguration AlertConfiguration { get; set; }
        public RewardProvidedAtLocation RewardProvidedAtLocation { get; set; }
 

        public int Credits { get; set; }
        public int Xp { get; set; }

        // only available when the configuration type is client 
        //TODO: make sure to check if we 
        public string RandomizedItems { get; set; } //predefined reward rotation group RaidMissionRewardsA
        public string ItemsArray { get; set; } // array of items  "/Lotus/StoreItems/Types/Recipes/Helmets/ValkyrAltBHelmetBlueprint" 


    }
}
