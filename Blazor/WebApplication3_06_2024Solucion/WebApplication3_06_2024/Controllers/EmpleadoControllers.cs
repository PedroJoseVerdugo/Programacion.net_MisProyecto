
using WebApplication3_06_2024;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using WebApplication3_06_2024.Models;

namespace WebApplication3_06_2024.Controllers
{
    {
        [Route("api/empleados")]
        [ApiController]
        public class EmpleadosController : ControllerBase
        {

            [HttpGet]
            public IActionResult VerEmpleado()
            {
                var empleado = new
                    Empleado("Tony", new DateTime(2021, 1, 1), "Tarde", 20000, 30, 4);
                return Ok(empleado);

            }


        }
    }
