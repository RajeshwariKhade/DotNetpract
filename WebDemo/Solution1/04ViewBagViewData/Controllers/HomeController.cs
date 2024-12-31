using _04ViewBagViewData.Model;
using Microsoft.AspNetCore.Mvc;

namespace _04ViewBagViewData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string[] arr = { "sunday","Monday"};
            ViewData["Days"]=arr;

            Emp emp = new Emp() {Id= 6, Name="xyz",Address= "pune" };
            ViewBag.EmpData = emp;
            
            return View();
        }
        public IActionResult Resultpage()
        {
            String[] arr = { "Tue", "Wed", "Fri" };
            ViewData["Days1"] = arr;
            return View();
        }


    }
}
