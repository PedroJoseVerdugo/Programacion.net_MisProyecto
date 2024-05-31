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
