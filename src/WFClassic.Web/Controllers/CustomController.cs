using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [AllowAnonymous]
    public class CustomController : ControllerBase
    {

        IConfiguration _configuration;

        public CustomController(IConfiguration configuration) { 
        
            this._configuration =   configuration;
        }


        [HttpGet]
        [Route("/custom/tunables.json")]
        public JsonResult GetTunables(string clientMod, string buildVersion)
        {
            // https://openwf.io/bootstrapper-manual
            return new JsonResult(new { nrs = "e-nrs.source.wf" });
        }
    }
}