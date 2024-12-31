using _06ModelViews.Model;
using Microsoft.AspNetCore.Mvc;

namespace _06ModelViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ProductViewModel productViewModel = new ProductViewModel()
            {
                Product = new Product() { PId = 101, PName = "Biscuit", Price = 112.25 },
                CategoryName = "Snacks",
                Description = "Best Quality",
                isInStock = true,

            };
            return View(productViewModel);
        }
       
        public IActionResult ProductDeatils(int PId)
        {
            Product product = new Product() { PId = 101, PName = "Biskit", Price = 109.0 };
            return View(product);
        }

    }
}
