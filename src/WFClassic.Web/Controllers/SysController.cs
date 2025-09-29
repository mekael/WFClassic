using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    public class SysController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BanPlayer() {


            return View();

        }


        [HttpPost]
        public IActionResult BanPlayer(Guid playerId)
        {
            // TODO: redirect to the ban list 
            return View();
        }



    }
}
