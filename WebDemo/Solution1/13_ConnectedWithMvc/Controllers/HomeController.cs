using System.Collections.Generic;
using _13ConnectedWithMvc.DAL;
using _13ConnectedWithMvc.Model;
using Microsoft.AspNetCore.Mvc;

namespace _13ConnectedWithMvc.Controllers
{
    public class HomeController : Controller
    {
         
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllRecord()
        {
          DbContex contex = new DbContex();
          List <Emp> emp = contex.GetAllEmps();
          return View(emp);
        }
        
    }
}
