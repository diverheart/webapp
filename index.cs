using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello, World!");
        }
    }
}