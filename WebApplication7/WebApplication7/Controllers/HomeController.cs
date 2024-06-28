using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<StudentModel>()
            {
                new StudentModel(){Id=1,Name="Abid",Description="Teacher"}
            };
            ViewData["StudentData"] = students;
            return View();
        }
    }
}
