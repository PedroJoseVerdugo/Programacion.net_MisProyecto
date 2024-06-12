using Microsoft.AspNetCore.Mvc;
using WebApplicationTrabajoFinalMvc.Models;

using WebApplicationTrabajoFinalMvc.ViewModels;

namespace WebMoneda4_5.Controllers;

public class UsuariosController : Controller
{
    public IActionResult MostrarUsuario()
    {
        var usuario = new Usuario();
        usuario.Nombre = "Dolores";
        usuario.Contraseña = "23435";
        usuario.Telefono = "68374293";
        usuario.Email = "email";

        return View(usuario);

    }
}
