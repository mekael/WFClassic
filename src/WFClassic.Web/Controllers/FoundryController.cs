using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json;
using WFClassic.Web.Logic.Foundry.Claim;
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
        ClaimCompletedRecipeHandler _claimCompletedRecipeHandler;
        ILogger<FoundryController> _logger;

        public FoundryController(ILogger<FoundryController> logger, CheckPendingRecipesQueryHandler checkPendingRecipesQueryHandler,
            StartRecipeBuildHandler startRecipeBuildHandler, ClaimCompletedRecipeHandler claimCompletedRecipeHandler)
        {
            _logger = logger;
            _checkPendingRecipesQueryHandler = checkPendingRecipesQueryHandler;
            _startRecipeBuildHandler = startRecipeBuildHandler;
            _claimCompletedRecipeHandler = claimCompletedRecipeHandler;
        }

        [HttpPost]
        [Route("/api/instantCompleteRecipe.php")]
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public ActionResult InstantCompleteRecipe([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            _logger.LogInformation("RecipeController => in action InstantCompleteRecipe");
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/claimCompletedRecipe.php")]
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public ActionResult ClaimCompletedItem([FromQuery]ClaimCompletedRecipe claimCompletedRecipe)
        {

            _logger.LogInformation("RecipeController => in action startRecipe");
            var result = _claimCompletedRecipeHandler.Handle(claimCompletedRecipe);

            if (result.ClaimCompletedRecipeResultStatus == ClaimCompletedRecipeResultStatus.DatabaseErrors ||
                result.ClaimCompletedRecipeResultStatus == ClaimCompletedRecipeResultStatus.MappingFailure)
            {
                return StatusCode(500);
            }
            else if (result.ClaimCompletedRecipeResultStatus == ClaimCompletedRecipeResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.ClaimCompletedRecipeResultStatus == ClaimCompletedRecipeResultStatus.Success)
            {
                return new JsonResult(result.BuiltItem);
            }

            return StatusCode(500);
        }

        [HttpPost]
        [Route("/api/startRecipe.php")]
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public ActionResult StartRecipe([FromQuery] StartRecipeBuild startRecipeBuild)
        {

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
