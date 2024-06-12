using Microsoft.AspNetCore.Mvc;
using WebApplicationTrabajoFinalMvc.Models.Servicios; // Asegúrate de que el espacio de nombres sea el correcto
using WebApplicationTrabajoFinalMvc.ViewModels; // Si este espacio de nombres es necesario

namespace WebApplicationTrabajoFinalMvc.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly ISaludo _saludo;

        public EmpresaController(ISaludo saludo)
        {
            _saludo = saludo;
        }

        public IActionResult Acercade()
        {
            ViewBag.empresa = "Klaus";
            ViewBag.telefono = "123123123";
            ViewBag.ceo = "Salvador";
            ViewBag.dedicacion = "Adiestramiento canino especializado en conducta.";
            ViewBag.saludo = _saludo.Saludo();

            return View();
        }

        public IActionResult Ayuda()
        {
            return View();
        }

        public IActionResult Prueba()
        {
            ISaludo saludo = new SaludoEnFrances();
            ViewBag.saludo = saludo.Saludo(); // Usando la instancia local de saludo
            return View();
        }
    }
}
