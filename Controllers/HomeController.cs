using Microsoft.AspNetCore.Mvc;

namespace MyTestProject.Controllers
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
        public IActionResult OurShop()
        {
            return View();
        }
    }
}
