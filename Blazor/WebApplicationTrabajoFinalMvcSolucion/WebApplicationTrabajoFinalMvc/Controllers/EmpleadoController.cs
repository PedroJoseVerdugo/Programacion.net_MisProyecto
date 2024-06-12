using Microsoft.AspNetCore.Mvc;
using WebApplicationTrabajoFinalMvc.Models.Servicios;

namespace WebApplicationTrabajoFinalMvc.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly ISaludo _saludo;

        // Constructor que inyecta ISaludo
        public EmpleadoController(ISaludo saludo)
        {
            _saludo = saludo;
        }

        // Acción del controlador
        public IActionResult Index()
        {
            // Utiliza _saludo aquí según sea necesario
            string mensajeSaludo = _saludo.Saludo();
            ViewData["MensajeSaludo"] = mensajeSaludo;

            return View();
        }
    }
}
