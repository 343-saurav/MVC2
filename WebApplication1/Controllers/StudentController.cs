using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Saurav";
            ViewBag.address = "Lucknow";
            return View();
        }
        public IActionResult Index2()
        {
            Models.Student student = new Models.Student { Name = "Saurav", Address = "Lucknow" };
            return View(student);
        }
    }
}
