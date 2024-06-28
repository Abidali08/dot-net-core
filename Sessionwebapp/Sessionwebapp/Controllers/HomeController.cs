using Microsoft.AspNetCore.Mvc;
using Sessionwebapp.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Sessionwebapp.Controllers
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

            HttpContext.Session.SetString("Name", "Abid Ali");
            TempData["SessionID"] = HttpContext.Session.Id;
            return View();
        }
        public IActionResult About()
        {
            //if (HttpContext.Session.GetString("Name") != null)
            //{
            //    ViewBag.Data = HttpContext.Session.GetString("Name").ToString();
            //}
            return View();
        }
        public IActionResult Details()
        {
            if (HttpContext.Session.GetString("Name") != null)
            {
                ViewBag.Data = HttpContext.Session.GetString("Name").ToString();
            }
            return View();
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("Name") != null)
            {
                HttpContext.Session.Remove("Name");
            }
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
