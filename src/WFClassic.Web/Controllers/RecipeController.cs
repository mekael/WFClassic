using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpPost]
        [Route("/api/instantCompleteRecipe.php")]
        public ActionResult InstantCompleteRecipe([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/claimCompletedRecipe.php")]
        public ActionResult ClaimCompletedRecipe([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/startRecipe.php")]
        public ActionResult StartRecipe([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/checkPendingRecipes.php")]
        public ActionResult CheckPendingRecipes([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }
    }
}
