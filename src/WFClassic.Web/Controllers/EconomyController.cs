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
    public class EconomyController : ControllerBase
    {
        private GetCreditsHandler _getCreditsHandler;

        public EconomyController(GetCreditsHandler getCreditsHandler)
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

            return new JsonResult(result.GetCreditsResultDetails,
        new JsonSerializerOptions { PropertyNamingPolicy = null });
        }

        [HttpGet]
        [Route("/api/purchase.php")]
        public ActionResult Purchase([FromQuery] Guid accountId, [FromQuery] long nonce, [FromQuery] string productName, [FromQuery] int usePremium)
        {
            return new JsonResult("{}");
        }
        [HttpPost]
        [Route("/api/forcePurchase.php")]
        public ActionResult ForcePurchase([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/sell.php")]
        public ActionResult Sell([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

    }
}
