using Microsoft.AspNetCore.Mvc;
using MyTestProject.ClassesEntity;
using Microsoft.EntityFrameworkCore; // For EF Core extensions
using Microsoft.Extensions.Logging; // For ILogger

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTestProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyIndexInformation _context; // Use your DbContext type

        public HomeController(ILogger<HomeController> logger, MyIndexInformation context) // Inject DbContext
        {
            _logger = logger;
            _context = context; // Assign injected DbContext to the field
        }

        public async Task<IActionResult> Index()
        {
            _logger.LogError("Index action is started!");
            List<IndexPagesInformation> indexPagesList = await _context.IndexInfo.ToListAsync();
            return View(indexPagesList[0]);
        }

        public IActionResult OurShop()
        {
            return View(); 
        }
    }
}
