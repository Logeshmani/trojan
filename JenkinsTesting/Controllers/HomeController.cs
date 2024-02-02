using JenkinsTesting.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JenkinsTesting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            ViewBag.Greetings = "Hi All, Welcome to Devops";
            return View();
        }

        public string Welcome()
        {
            return "Devops is easy";
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
