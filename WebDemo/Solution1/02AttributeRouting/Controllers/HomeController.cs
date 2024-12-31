using Microsoft.AspNetCore.Mvc;

namespace _02AttributeRouting.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
