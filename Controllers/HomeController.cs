using Coffee.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Coffee.Controllers
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
            return View();
        }
        //public IActionResult result(string firstName, string lastName, string email, string password)
        //{
        //    string result = $"Thank you for your registration {firstName} {lastName}!";
        //    return View("Registration", result);
        //}
        public IActionResult result(User c)
        {
            return View(c);
        }

        public IActionResult registration()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ProductIndex(User P)
        {
            return View(P);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}