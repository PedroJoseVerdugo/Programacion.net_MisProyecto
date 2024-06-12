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
        usuario.FechaNacimiento = new DateTime(2024, 6, 1);
        usuario.Email = "email";
        usuario.NombreUsuario = "SobreNombre";
        usuario.Pais = "España";

        return View(usuario);

    }
}
