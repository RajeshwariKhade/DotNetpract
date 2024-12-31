using Microsoft.AspNetCore.Mvc;
using _08ParsalView.Model;
namespace _08ParsalView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> product = new List<Product>()
            {
                new Product() {Id =89,Name="mobile",Price=8900,Image="~/images/Mobile.jpg"},
                new Product(){Id =78,Name="Laptop",Price=90000,Image="~/images/Laptop.jpeg"},
                new Product(){Id=80,Name="HDD",Price=7999,Image="~/images/HDD.jpg"}
            };


            return View(product);
        }
        
    }
}
