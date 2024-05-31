using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebAspnVavio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolaMundoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Saludo()
        {
            return Ok("Hola Mundo como estaaaaa!!!!!");
        }
    }
    /*
    public class EmpleadoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Saludo()
        {
            var empleado = new Empleado("Tony", new DataTime(2021, 1, 1), "Tarde", 200000, 30, 4);
            return ok(empleado);

        }*/
    }



/*
namespace ApiConversorProyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolaMundoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Saludo()
        {
            return Ok("Hola Mundo !!!!!");
        }
    }
}*/
