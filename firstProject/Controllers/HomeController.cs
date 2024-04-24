using firstProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace firstProject.Controllers
{

    public record Person(string firstName, string lastName, int age, double height);

    [Route("[Controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Attribute Based Routing


        //[Route("")]
        //[Route("Home")]
        [Route("")]
        [Route("[Action]")]
        public IActionResult Index()
        {
            string a = "Hye";
            ViewData["data"] = a;


            List<string> projects = new()
            {
                "CRM", "HMS","Tracking app"
            };

            TempData["projects"] = projects;

            Person amjad = new("Amjad","Khan",54,5.6);

            List<Person> personsList = new()
            {
                new Person("Zahid","Asfar",34,3.4),
                new Person("Amjad","Arif",56,2.4),
                new Person("Azeem","Shah",32,6.4),
                new Person("Haris","Gul",38,5.4),
                new Person("Talib","Qazi",39,7.4),
            };

            ViewBag.persons = personsList;



            //ViewData["employees"] = employees;
            //ViewData["projects"] = projects;

            //ViewBag.prj = projects;
    
       
            return View("Index");
        }

        //[Route("/Home/P")]
        [Route("[Action]")]

        public IActionResult Privacy()
        {

            return View("");

        }
        //[Route("/Home/About")]
        [Route("[Action]")]
        public IActionResult About()
        {
      
            return View();
        }
        //[Route("[Action]")]
        [Route("[Action]")]
        public IActionResult Contact()
        {
            return Json(new { name = "usama" });
        }
        [Route("[Action]")]
        public string S()
        {
            string a = "Hello";
            return a;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}