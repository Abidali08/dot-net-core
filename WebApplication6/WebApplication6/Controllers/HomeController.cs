using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication6.Models;
using WebApplication6.Repository;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<StudentModel> getAllStudents()
        {
            return _studentRepository.getAllStudents();
        }
        public StudentModel getById(int id)
        {
            return _studentRepository.getStudentById(id);
        }

        public IActionResult Index()
        {
            //var students = new List<StudentModel>()
            //{
            //    new StudentModel() {STDID = 1,Name="Abid",Gender="Male",Semester="3"},
            //    new StudentModel() {STDID = 2,Name="Adil",Gender="Male",Semester="4"},
            //    new StudentModel() {STDID = 2,Name="Farheen",Gender="Female",Semester="5"},
            //    new StudentModel() {STDID = 2,Name="Rayyan",Gender="Male",Semester="3"},
            //    new StudentModel() {STDID = 2,Name="Aysha",Gender="Female",Semester="2"},
            //};
            //ViewData["StudentData"] = students;
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
