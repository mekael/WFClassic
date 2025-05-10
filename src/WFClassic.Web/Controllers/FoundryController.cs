using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json;
using WFClassic.Web.Logic.Foundry.Pending;
using WFClassic.Web.Logic.Foundry.Start;
using WFClassic.Web.Logic.Friendship.Get;
using WFClassic.Web.Logic.Middleware;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class FoundryController : ControllerBase
    {
        CheckPendingRecipesQueryHandler _checkPendingRecipesQueryHandler;
        StartRecipeBuildHandler _startRecipeBuildHandler;
        ILogger<FoundryController> _logger;

        public FoundryController(ILogger<FoundryController> logger, CheckPendingRecipesQueryHandler checkPendingRecipesQueryHandler,
            StartRecipeBuildHandler startRecipeBuildHandler )
        {
            _logger = logger;
            _checkPendingRecipesQueryHandler = checkPendingRecipesQueryHandler;
            _startRecipeBuildHandler = startRecipeBuildHandler;
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
        public ActionResult StartRecipe([FromQuery] StartRecipeBuild startRecipeBuild)
        {
            //   Utils.GetRequestObject<string>(this.HttpContext);
            // Seems like the array is always empty ? 
  

            _logger.LogInformation("RecipeController => in action startRecipe");
            var result = _startRecipeBuildHandler.Handle(startRecipeBuild);

            if (result.StartRecipeBuildResultStatus == StartRecipeBuildResultStatus.DatabaseErrors ||
                result.StartRecipeBuildResultStatus == StartRecipeBuildResultStatus.MappingFailure)
            {
                return StatusCode(500);
            }
            else if (result.StartRecipeBuildResultStatus == StartRecipeBuildResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.StartRecipeBuildResultStatus == StartRecipeBuildResultStatus.Success)
            {
                    return Ok();
            }

            return StatusCode(500);
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
