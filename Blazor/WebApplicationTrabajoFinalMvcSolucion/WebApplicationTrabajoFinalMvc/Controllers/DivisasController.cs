using Microsoft.AspNetCore.Mvc;
using WebApplicationTrabajoFinalMvc.Models;

namespace WebApplicationTrabajoFinalMvc.Controllers
{
    public class DivisasController : Controller
    {
        public IActionResult MostrarDivisa()
        {
            var divisa = new Divisa();
            divisa.Nombre = "Maria";
            divisa.Codigo = 11111;

            return View(divisa);
        }
    }
}
