using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Credits.Get;
using WFClassic.Web.Logic.Economics.Purchase;
using WFClassic.Web.Logic.Economics.Revives;
using WFClassic.Web.Logic.Economics.Sell;
using WFClassic.Web.Logic.Middleware;
using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [TypeFilter(typeof(LoginVerificationActionFilter))]
    public class EconomyController : ControllerBase
    {
        private GetCreditsHandler _getCreditsHandler;
        private SellItemHandler _sellItemHandler;
        private PurchaseItemHandler _purchaseItemHandler;
        private PurchaseRevivesHandler _purchaseRevivesHandler;

        public EconomyController(GetCreditsHandler getCreditsHandler, SellItemHandler sellItemHandler,
            PurchaseItemHandler purchaseItemHandler, PurchaseRevivesHandler purchaseRevivesHandler)
        {
            _getCreditsHandler = getCreditsHandler;
            _sellItemHandler = sellItemHandler;
            _purchaseItemHandler = purchaseItemHandler;
            _purchaseRevivesHandler = purchaseRevivesHandler;
        }

        [HttpPost]
        [Route("/api/refillRevives.php")]
        public ActionResult RefillRevives([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            PurchaseRevives purchaseRevives = new PurchaseRevives()
            {
                AccountId = accountId,
                Nonce = nonce,
                IncomingRefillRevivesJsonObject = Utils.GetRequestObject<IncomingRefillRevivesJsonObject>(this.HttpContext)
            };

            var result = _purchaseRevivesHandler.Handle(purchaseRevives);
            if (result.PurchaseRevivesResultStatus == PurchaseRevivesResultStatus.DatabaseErrors  )
            {
                return StatusCode(500);
            }
            else if (result.PurchaseRevivesResultStatus == PurchaseRevivesResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.PurchaseRevivesResultStatus == PurchaseRevivesResultStatus.Success)
            {
                return Ok();
            }

            return StatusCode(500);


         }


        [Route("api/credits.php")]
        [HttpGet]
        public IActionResult GetAccountBalances([FromQuery] GetCredits getCredits)
        {
            var result = _getCreditsHandler.Handle(getCredits);

            if (result.GetCreditsResultStatus == GetCreditsResultStatus.Failure)
            {
                return StatusCode(500);
            }
            else if (result.GetCreditsResultStatus == GetCreditsResultStatus.ValidationErrors)
            {
                return BadRequest();
            }

            return new JsonResult(result.GetCreditsResultDetails,
        new JsonSerializerOptions { PropertyNamingPolicy = null });
        }

        [HttpGet]
        [Route("/api/purchase.php")]
        public ActionResult Purchase([FromQuery] PurchaseItem purchaseItem)
        {
            var result = _purchaseItemHandler.Handle(purchaseItem);

            // purchase something from the shop
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/forcePurchase.php")]
        public ActionResult ForcePurchase([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            // maybe trade?
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/sell.php")]
        public ActionResult SellItemToLotus([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            SellItem sellItem = new SellItem()
            {
                AccountId = accountId,
                Nonce = nonce,
                IncomingSaleJson = Utils.GetRequestObject<IncomingSaleJson>(this.HttpContext)
            };
            var result = _sellItemHandler.Handle(sellItem);
            if (result.SellItemResultStatus == SellItemResultStatus.DatabaseErrors ||
                result.SellItemResultStatus == SellItemResultStatus.MappingFailure)
            {
                return StatusCode(500);
            }
            else if (result.SellItemResultStatus == SellItemResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.SellItemResultStatus == SellItemResultStatus.Success)
            {
                return Ok();
            }

            return StatusCode(500);
        }
    }
}