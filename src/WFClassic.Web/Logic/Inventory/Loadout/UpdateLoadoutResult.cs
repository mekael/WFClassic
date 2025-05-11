using Newtonsoft.Json;
using Org.BouncyCastle.Bcpg.Sig;
using System.Text.Json.Serialization;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Inventory.Loadout
{
    public class UpdateLoadoutResult
    {
        public UpdateLoadoutResultStatus UpdateLoadoutResultStatus { get; set; }
     }

 
    
    public enum UpdateLoadoutResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success
    }

}
