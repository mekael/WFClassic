using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json;
using WFClassic.Web.Logic.Foundry.Pending;
using WFClassic.Web.Logic.Friendship.Get;
using WFClassic.Web.Logic.Middleware;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class RecipeController : ControllerBase
    {
        CheckPendingRecipesQueryHandler _checkPendingRecipesQueryHandler;
        ILogger<RecipeController> _logger;

        public RecipeController(ILogger<RecipeController> logger, CheckPendingRecipesQueryHandler checkPendingRecipesQueryHandler)
        {
            _logger = logger;
            _checkPendingRecipesQueryHandler = checkPendingRecipesQueryHandler;
        }

        [HttpPost]
        [Route("/api/instantCompleteRecipe.php")]
        public ActionResult InstantCompleteRecipe([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            _logger.LogInformation("RecipeController => in action InstantCompleteRecipe");
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/claimCompletedRecipe.php")]
        public ActionResult ClaimCompletedRecipe([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            _logger.LogInformation("RecipeController => in action claimCompletedRecipe");
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/startRecipe.php")]
        public ActionResult StartRecipe([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            //   Utils.GetRequestObject<string>(this.HttpContext);
            // Seems like the array is always empty ? 

            _logger.LogInformation("RecipeController => in action startRecipe");
            return new JsonResult("{}");
        }

        [HttpGet]
        [Route("/api/checkPendingRecipes.php")]
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public ActionResult Pending([FromQuery] CheckPendingRecipesQuery checkPendingRecipesQuery)
        {

            _logger.LogInformation("RecipeController =>  checkPendingRecipes");
            var result = _checkPendingRecipesQueryHandler.Handle(checkPendingRecipesQuery);

            if (result.CheckPendingRecipesResultStatus == CheckPendingRecipesResultStatus.DatabaseErrors ||
                result.CheckPendingRecipesResultStatus == CheckPendingRecipesResultStatus.MappingFailure)
            {
                return StatusCode(500);
            }
            else if (result.CheckPendingRecipesResultStatus == CheckPendingRecipesResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.CheckPendingRecipesResultStatus == CheckPendingRecipesResultStatus.Success)
            {
                return new JsonResult(result.JsonCheckPendingRecipesResult,
        new JsonSerializerOptions { PropertyNamingPolicy = null });
            }

            return StatusCode(500);

        }
    }
}
