global using Microsoft.AspNetCore.Mvc;
global using ProyectowebMVC.Servicios;

namespace ProyectowebMVC.Controllers;

public class EmpresaController : Controller
{
    private readonly ISaludo _saludo;

    public EmpresaController(ISaludo saludo)
    {
        _saludo = saludo;
    }



    public IActionResult Acercade()
    {
       

        ViewBag.empresa = "Saltoki";
        ViewBag.telefono = "17899 ";
        ViewBag.ceo = " el boss";
        ViewBag.dedicatocion = "pipipppi";

        //ISaludo saludo = new SaludoEnFrances();
        ViewBag.saludo = _saludo.Saludo();
       
        return View();
    }
    public IActionResult Prueba()
    {
        //ISaludo saludo = new SaludoEnFrances();
        ViewBag.saludo = _saludo.Saludo();
        return View();
    }
}
