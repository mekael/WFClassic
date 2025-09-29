using WFClassic.Web.Data.Models;
using WFClassic.Web.Data;
using WFClassic.Web.Logic.Taunt;

namespace WFClassic.Web.Logic.UI.SinglePlayer
{
    public class GetPlayerProfileInfoHandler
    {

        private ApplicationDbContext _applicationDbContext;
        private ILogger<GetPlayerProfileInfoHandler> _logger;

        public GetPlayerProfileInfoHandler(ApplicationDbContext applicationDbContext, ILogger<GetPlayerProfileInfoHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public GetPlayerProfileInfoResult Handle(GetPlayerProfileInfo getPlayerProfileInfo)
        {
            GetPlayerProfileInfoResult result = new GetPlayerProfileInfoResult();


            /*
             
             username
             current mastery rank
            founder type
            current login streak
            current login status
            join date
            last login date
            is banned
            profile description ? 

            guild member
            rank in guild


             
             
             */



            /*
             
             achievement name
            achievement short code
            achievement type (kill an enemy, kill x enemies with a weapon type , complete a node, hit rank 30 with a certain weapon or weapon group, play for a certain amount of time.)
            achievement level (mission, overall, na) 

             
             
             */

 
  
  
            try
            {
                _logger.LogInformation("GetPlayerProfileInfoHandler => Starting player query");
 
                _logger.LogInformation("GetPlayerProfileInfoHandler => Player query complete");
            }
            catch (Exception ex)
            {
                _logger.LogError("GetPlayerProfileInfoHandler => Exception while querying for players {Exception}", ex);
                result.GetPlayerProfileInfoResultStatus = GetPlayerProfileInfoResultStatus.DatabaseErrors;
                return result;
            }

 
   
            return result;
        }
    }
}