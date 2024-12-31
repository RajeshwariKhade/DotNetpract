using Microsoft.AspNetCore.Mvc;

namespace _03ActionMethod.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult<string> Getsomedata(string name,string lastname)
        {
            string result = $"name ={name},lastname = {lastname}";
            return result ;
        }
        public string getsomestring(int id,string name)
        {
            string output = $"ID = {id},name ={name}";
            return output ;

        }

        public string getsomestring1(int Id, string name)
        {
            string output = $"ID = {Id},name ={name}";
            return output;

        }
        public JsonResult GetResult()
        {
            var data = new { name="Riya",address="pune"};
            return Json(data);
        }

        public FileResult DownloadFile()
        {
            var byteArray = System.IO.File.ReadAllBytes(@"C:\Users\IET\Desktop\67 & 49\.NET\WebDemo\Solution1\03ActionMethod\Data\Top 300 SQL MCQ CCEE.pdf");
            return File(byteArray, "application/pdf", "demo.pdf");
        }

    }
}
