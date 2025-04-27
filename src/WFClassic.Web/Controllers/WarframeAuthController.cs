using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Shared;
using WFClassic.Web.Logic.WFAuth.WFLogin;
using WFClassic.Web.Logic.WFAuth.WFLogout;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class WarframeAuthController : ControllerBase
    {
        private readonly WarframeLoginHandler _warframeLoginHandler;
        private readonly WarframeLogoutHandler _warframeLogoutHandler;

        public WarframeAuthController(WarframeLoginHandler warframeLoginHandler, WarframeLogoutHandler warframeLogoutHandler)
        {
            _warframeLoginHandler = warframeLoginHandler;
            _warframeLogoutHandler = warframeLogoutHandler;
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
        public async Task<IActionResult> GetAsync([FromQuery] WarframeLogoutRequest warframeLogoutRequest)
        {

            var result = await _warframeLogoutHandler.Handle(warframeLogoutRequest);

            if (result.WarframeLogoutResultStatus == WarframeLogoutResultStatus.BadRequest)
            {
                return BadRequest();
            }
            else if (result.WarframeLogoutResultStatus == WarframeLogoutResultStatus.NotFound)
            {
                return NotFound();
            }
            else if (result.WarframeLogoutResultStatus == WarframeLogoutResultStatus.NonceDoesNotMatch)
            {
                return StatusCode(403);
            }
            else if (result.WarframeLogoutResultStatus == WarframeLogoutResultStatus.Failure)
            {
                return StatusCode(500);
            }

            return Ok();

        }



    }
}
