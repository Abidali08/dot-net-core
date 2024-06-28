using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication11.Models;
using Microsoft.AspNetCore.Http;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name","Abid Ali");
            return View();
        }

        public IActionResult About()
        {
            //if(HttpContext.Session.GetString("Name") != null)
            //{
            //    ViewBag.Data = HttpContext.Session.GetString("Name").ToString();
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
