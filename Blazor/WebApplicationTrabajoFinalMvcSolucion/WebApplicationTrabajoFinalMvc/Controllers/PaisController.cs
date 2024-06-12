using Microsoft.AspNetCore.Mvc;
using WebApplicationTrabajoFinalMvc.Models;

namespace WebApplicationTrabajoFinalMvc.Controllers
{
    public class PaisController : Controller
    {
        public IActionResult MostrarPais()
        {
            var pais = new Pais();
            pais.Id = "2";
            pais.Nombre = "Juan";
            pais.Capital = "Madrid";
            pais.Moneda = "Euro";

            return View(pais);
        }
    }
}
