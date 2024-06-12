using Microsoft.AspNetCore.Mvc;
using WebApplicationTrabajoFinalMvc.Models;

namespace WebApplicationTrabajoFinalMvc.Controllers;

public class UsuariosController : Controller
{
    public IActionResult MostrarUsuario()
    {
        var usuario = new Usuario();
        usuario.Nombre = "Dolores";
        usuario.Contraseña = "23435";
        usuario.FechaNacimiento = "julio de 5 del 2024" ;
        usuario.Email = "email";

        return View(usuario);

    }
}
