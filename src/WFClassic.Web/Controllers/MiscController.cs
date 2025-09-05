using System.Text.Json;

using Microsoft.AspNetCore.Mvc;

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
        private readonly AddLevelBasedOnTrainingHandler _addLevelBasedOnTrainingHandler;
        private readonly AddTauntHandler _addTauntHandler;

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
            // this is most likely an unused endpoint that was originally meant to 
            // add more charges/usages to the artifact cards. There is no way to really verify this though.

            return new JsonResult("{}");
        }


        [HttpPost]
        [Route("/api/recharge.php")]
        public ActionResult Recharge([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Utils.GetRequestObjectAsString(this.HttpContext);
            // the only item that uses the endpoint is "/Lotus/Types/Restoratives/ChargeableSelfHeal"
            // but it is not marked as being available in the marketplace nor does it look to be an easily accessible item. 
            // this might be an item / piece of functionality that was cut in the later versions of the game (no way to tell if it was available previously) . 
            // the description is 
            /*
             Permanent item (non-disposable) that uses charge when it heals. Can be recharged between missions for a small fee
             
             */

            // this is the body passed by the client. 
            // ChargeRecovery corresponds with the "Charges" field. 
            // Cost is based on the usage percentage of the self heal. 
            // it's 2 plat per every hundred charges (which ends up being hit points anyways)
            // 

            /*
             {
    "ItemType" : "/Lotus/Types/Restoratives/ChargeableSelfHeal",
    "ChargeRecovery" : 500,
    "Cost" : 10
}
             
             
             */
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