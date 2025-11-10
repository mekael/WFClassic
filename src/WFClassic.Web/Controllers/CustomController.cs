using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class CustomController : ControllerBase
    {
        [HttpGet]
        [Route("/custom/tunables.json")]
        public IActionResult GetTunables()
        {
            // https://openwf.io/bootstrapper-manual
            return new JsonResult(new { });
        }
    }
}