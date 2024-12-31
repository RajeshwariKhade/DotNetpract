using _05CRUDDemo.DAL;
using _05CRUDDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05CRUDDemo.Controllers
{
    public class HomeController : Controller
    {
        DbContextDemo dbContext = new DbContextDemo();

        
        public IActionResult Create()
        {
           
            return View();
        }

        
        public IActionResult Index()
        {
            var allEmployees = dbContext.employees.ToList();
            return View(allEmployees);
        }

        [HttpPost]
        public ActionResult<string> AddEmpToDB(Employee emp)
        {
            Employee employee = new Employee()
            {
                
                EName = emp.EName,
                EAddress = emp.EAddress
            };
            dbContext.employees.Add(employee);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Employee emp = dbContext.employees.Find(id);
            return View(emp);
        }
       
        public ActionResult<string> DeleteFromDB(Employee emp)
        {
            Employee employee = dbContext.employees.Find(emp.EId);
            dbContext.employees.Remove(employee);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Employee emp = dbContext.employees.Find(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult<string> EditToDB(Employee emp)
        {
            Employee employee = dbContext.employees.Find(emp.EId);
            employee.EName = emp.EName;
            employee.EAddress = emp.EAddress;
            dbContext.employees.Update(employee);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
