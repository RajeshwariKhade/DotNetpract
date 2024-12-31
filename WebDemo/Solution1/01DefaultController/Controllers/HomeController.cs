using Microsoft.AspNetCore.Mvc;

namespace _01DefaultController.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
