global using Microsoft.AspNetCore.Mvc;
global using ProyectowebMVC.Models;

namespace ProyectowebMVC.Controllers;

public class UsuariosController : Controller
{
    public IActionResult Index()
    {

        var usuario = new Usuario();

        usuario.Nmbre = "Dolores ";

        usuario.Apellido = "Verdugo";
        usuario.Dni = "45678V";
        usuario.Email = "pep@gmail.com";
        usuario.IdUsuario = "1";

        return View(usuario);
    }
}
