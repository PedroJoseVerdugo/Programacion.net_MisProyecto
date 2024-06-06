global using Microsoft.AspNetCore.Mvc;
global using ProyectowebMVC.Models;
global using System.Diagnostics;
using ProyectowebMVC.ViewModels;
using System.Net;
using System.Xml.Linq;

namespace ProyectowebMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var ViewModel = new HomeIndexViewModel();

        ViewModel.Vision = "Mejorando dia a dia";
        ViewModel.NombreEmpresa = "Saltoki";
        ViewModel.Name = "Pedro jose";
        ViewModel.Dni = "12334456";
        ViewModel.Description = "ESta es la descripcion";
        ViewModel.Telefono = "111111111";

        return View(ViewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
