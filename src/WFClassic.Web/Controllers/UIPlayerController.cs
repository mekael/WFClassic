using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WFClassic.Web.Logic.UI.ListPlayers;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WFClassic.Web.Controllers
{
    [Authorize]
    public class UIPlayerController : Controller
    {

        readonly GetPlayerListHandler _getPlayerListHandler;

        public UIPlayerController(GetPlayerListHandler getPlayerListHandler)
        {
            _getPlayerListHandler = getPlayerListHandler;
        }


        [Route("/players/")]
        public IActionResult Index()
        {

            return View();
        }


        [Route("/getPlayerData/")]
        [HttpGet]
        public IActionResult GetPlayerData()
        {

            GetPlayerList getPlayerList = new GetPlayerList() { NumberOfItemsPerPage = 50, PageNumber = 1 };


            var result = _getPlayerListHandler.Handle(getPlayerList);

            if (result.GetPlayerListResultStatus == GetPlayerListResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }
            else if (result.GetPlayerListResultStatus == GetPlayerListResultStatus.ValidationErrors)
            {
                return BadRequest();
            }

            var jsonData = new { recordsFiltered = result.GetPlayerListResultDetailItems.Count, recordsTotal = result.GetPlayerListResultDetailItems.Count, data = result.GetPlayerListResultDetailItems };
            return Ok(jsonData);
        }




    }
}