using Microsoft.AspNetCore.Mvc;

namespace _09_CurdMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
