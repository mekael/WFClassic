using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Exp.Training;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class MiscController : ControllerBase
    {
        AddLevelBasedOnTrainingHandler _addLevelBasedOnTrainingHandler;
        public MiscController(AddLevelBasedOnTrainingHandler addLevelBasedOnTrainingHandler) {
        
        _addLevelBasedOnTrainingHandler = addLevelBasedOnTrainingHandler;   
        }

        [HttpGet]
        [Route("/api/trainingResult.php")]
        public ActionResult TrainingResult([FromQuery] AddLevelBasedOnTraining addLevelBasedOnTraining )
        {
           var result = _addLevelBasedOnTrainingHandler.Handle(addLevelBasedOnTraining);


            return new JsonResult(result,
        new JsonSerializerOptions { PropertyNamingPolicy = null });
        }

        [HttpPost]
        [Route("/api/refillCard.php")]
        public ActionResult RefillCard([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }


        [HttpPost]
        [Route("/api/refillRevives.php")]
        public ActionResult RefillRevives([FromQuery] Guid accountId, [FromQuery] long nonce)
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
            return new JsonResult("{}");
        }

    }

}
