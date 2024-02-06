using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    public class HelloWorldController : Controller
    {

        // Index Route
        public IActionResult Index()
        {
            return View();
        }

        // Welcome Route
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
