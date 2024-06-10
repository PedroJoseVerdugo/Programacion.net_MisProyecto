using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationTrabajoFinalMvc.Models;

namespace WebApplicationTrabajoFinalMvc.Controllers
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

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Conversor()
        {
            return View();
        }

        public IActionResult Monedas()
        {
            return View();
        }

        public IActionResult Sobremi()
        {
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
