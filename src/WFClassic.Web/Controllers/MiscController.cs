using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Exp.Training;
using WFClassic.Web.Logic.Middleware;
using WFClassic.Web.Logic.Shared;
using WFClassic.Web.Logic.Taunt;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [TypeFilter(typeof(LoginVerificationActionFilter))]
    public class MiscController : ControllerBase
    {
        private AddLevelBasedOnTrainingHandler _addLevelBasedOnTrainingHandler;
        private AddTauntHandler _addTauntHandler;

        public MiscController(AddLevelBasedOnTrainingHandler addLevelBasedOnTrainingHandler, AddTauntHandler addTauntHandler)
        {
            _addLevelBasedOnTrainingHandler = addLevelBasedOnTrainingHandler;
            _addTauntHandler = addTauntHandler;
        }

        [HttpGet]
        [Route("/api/trainingResult.php")]
        public ActionResult TrainingResult([FromQuery] AddLevelBasedOnTraining addLevelBasedOnTraining)
        {
            var result = _addLevelBasedOnTrainingHandler.Handle(addLevelBasedOnTraining);
            if (result.AddLevelBasedOnTrainingResultStatus == AddLevelBasedOnTrainingResultStatus.Success)
            {
                return new JsonResult(result, new JsonSerializerOptions { PropertyNamingPolicy = null });
            }
            else if (result.AddLevelBasedOnTrainingResultStatus == AddLevelBasedOnTrainingResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.AddLevelBasedOnTrainingResultStatus == AddLevelBasedOnTrainingResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }
            return StatusCode(500);
        }

        [HttpPost]
        [Route("/api/refillCard.php")]
        public ActionResult RefillCard([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }


        [HttpPost]
        [Route("/api/recharge.php")]
        public ActionResult Recharge([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/tauntHistory.php")]
        public ActionResult TauntHistory([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            IncomingAddTaunt incomingAddTaunt = Utils.GetRequestObject<IncomingAddTaunt>(this.HttpContext);
            AddTaunt addTaunt = new AddTaunt()
            {
                AccountId = accountId,
                IncomingAddTaunt = incomingAddTaunt,
                Nonce = nonce
            };

            var result = _addTauntHandler.Handle(addTaunt);

            if (result.AddTauntResultStatus == AddTauntResultStatus.Success)
            {
                return new JsonResult(incomingAddTaunt.Node);
            }
            else if (result.AddTauntResultStatus == AddTauntResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.AddTauntResultStatus == AddTauntResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }

            return new JsonResult("{}");
        }




    }
}