using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Credits.Get;
using WFClassic.Web.Logic.Shared;
using WFClassic.Web.Logic.WFAuth.WFLogin;
using WFClassic.Web.Logic.WFAuth.WFLogout;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class CreditController : ControllerBase
    {
        private GetCreditsHandler _getCreditsHandler;

        public CreditController(GetCreditsHandler getCreditsHandler)
        {
            _getCreditsHandler = getCreditsHandler;
        }

        [Route("api/credits.php")]
        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] GetCredits getCredits)
        {

            var result = _getCreditsHandler.Handle(getCredits);

            if (result.GetCreditsResultStatus == GetCreditsResultStatus.Failure)
            {
                return StatusCode(500);
            }
            else if (result.GetCreditsResultStatus == GetCreditsResultStatus.LoginCheckFailure)
            {
                return StatusCode(403);
            }
            else if (result.GetCreditsResultStatus == GetCreditsResultStatus.ValidationErrors)
            {
                return BadRequest();
            }

            return new JsonResult(result.GetCreditsResultDetails);
        }



    }
}
