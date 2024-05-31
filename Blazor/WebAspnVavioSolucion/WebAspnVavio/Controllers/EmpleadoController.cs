using Microsoft.AspNetCore.Mvc;
using WebAspnVavio.model;

namespace WebAspnVavio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        [HttpGet]
        public IActionResult VerEmpleado()
        {

            var empleado = new Empleado("Maria", new DateTime(2021, 1, 1), "Tarde", 200000, 30);
            var empleado5 = new Empleado("Tony", new DateTime(2021, 1, 1), "Tarde", 200000, 30);
            var empleado1 = new Empleado("Ana", new DateTime(2020, 5, 15), "Mañana", 250000, 25);
            var empleado2 = new Empleado("Luis", new DateTime(2019, 8, 22), "Noche", 180000, 20);
            var empleado3 = new Empleado("María", new DateTime(2022, 3, 10), "Tarde", 220000, 28);

            var empleados = new List<Empleado> { empleado, empleado1, empleado2, empleado3, empleado5 };
            return Ok(empleados);

        }
    }
}
