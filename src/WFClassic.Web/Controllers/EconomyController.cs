using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Credits.Get;
using WFClassic.Web.Logic.Middleware;
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
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public async Task<IActionResult> GetAsync([FromQuery] GetCredits getCredits)
        {

            var result = _getCreditsHandler.Handle(getCredits);

            if (result.GetCreditsResultStatus == GetCreditsResultStatus.Failure)
            {
                return StatusCode(500);
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
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public ActionResult Purchase([FromQuery] Guid accountId, [FromQuery] long nonce, [FromQuery] string productName, [FromQuery] int usePremium)
        {
            // purchase something from the shop
            return new JsonResult("{}");
        }
        
        [HttpPost]
        [Route("/api/forcePurchase.php")]
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public ActionResult ForcePurchase([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            // maybe trade? 
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/sell.php")]
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public ActionResult Sell([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            // Sell an inventory item back to the lotus 
            return new JsonResult("{}");
        }

    }
}
