using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["data1"] = "Eduloge";
            ViewData["data2"] = 25;
            ViewData["data3"] = DateTime.Now.ToLongDateString();
            ViewData["data4"] = 8.8;

            string[] arr = { "Abid", "Ali", "Amjad" };

            ViewData["data5"] = arr;

            ViewData["data6"] = new List<string>()
            {
                "Circket","FootBall","Hockey"
            };
            return View();
        }
        public IActionResult About()
        {
            ViewBag.data1 = "Eduloge";
            ViewBag.data2 = 24;
            ViewBag.data3 = DateTime.Now.ToShortDateString();
            string[] arr = { "Abid", "Ali", "Amjad" };
            ViewBag.data4 = arr;
            ViewBag.data5 = new List<string>(){
                "Circket","FootBall","Hockey"
            };

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["data2"] = "View Data";
            ViewBag.data1 = "View Bag";
            TempData["dataa3"] = "Temp Data";
            TempData.Keep();
            return View();
        }
    }
}
