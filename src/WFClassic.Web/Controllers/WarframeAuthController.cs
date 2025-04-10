using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Shared;
using WFClassic.Web.Logic.WFAuth.WFLogin;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class WarframeAuthController : ControllerBase
    {
        private readonly WarframeLoginHandler _warframeLoginHandler;

        public WarframeAuthController(WarframeLoginHandler warframeLoginHandler)
        {
            _warframeLoginHandler = warframeLoginHandler;
        }




        [Route("api/login.php")]
        [HttpPost]

        public async Task<IActionResult> PostAsync()
        {
            var request = Utils.GetRequestObject<WarframeLoginRequest>(this.HttpContext);
            request.HostName = this.HttpContext.Request.Host.ToString();

            var result = await _warframeLoginHandler.Handle(request);
            if (result.WarframeLoginResultStatus == WarframeLoginResultStatus.BadRequest
                && result.WarframeLoginResultStatus == WarframeLoginResultStatus.InvalidCredentials)
            {
                return BadRequest();
            }
            else if (result.WarframeLoginResultStatus == WarframeLoginResultStatus.UserNotFound)
            {
                return NotFound();

            }
            else if (result.WarframeLoginResultStatus == WarframeLoginResultStatus.Failure)
            {
                return StatusCode(500);
            }

            return new JsonResult(result.WarframeLoginResultDetails,
        new JsonSerializerOptions { PropertyNamingPolicy = null });
        }

        [Route("api/logout.php")]
        [HttpGet]
        public async Task<IActionResult> GetAsync(string accountId, long nonce) 
        {

        return Ok();

        }



    }
}
