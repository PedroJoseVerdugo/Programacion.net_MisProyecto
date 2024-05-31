using Microsoft.AspNetCore.Mvc;
using WebAspnVavio.Model;
using System.Collections.Generic;

namespace WebAspnVavio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public IActionResult VerAnimales()
        {
            var animal1 = new Animal("Luna", "Perro", new DateTime(2018, 5, 20), 20.5, 0.5);
            var animal2 = new Animal("Milo", "Gato", new DateTime(2020, 8, 15), 4.3, 0.3);
            var animal3 = new Animal("Max", "Conejo", new DateTime(2019, 3, 10), 2.1, 0.2);
            var animal4 = new Animal("Bella", "Caballo", new DateTime(2015, 6, 1), 500, 1.7);

            var animales = new List<Animal> { animal1, animal2, animal3, animal4 };

            return Ok(animales);
        }
    }
}
