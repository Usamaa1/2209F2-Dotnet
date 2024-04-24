using dummy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dummy.Controllers
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

            List<string> projects = new() { "HMS", "CRM", "Tracking App" };

            TempData["projects"] = projects;

            return View();
        }

        public IActionResult Privacy()
        {
            TempData.Keep("projects");
            return View();
        }


        public IActionResult About()
        {
            TempData.Keep("projects");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}