
namespace ProyectowebMVC.Controllers;

public class ConversorController : Controller
{
    private readonly ServicioConversionMoneda servicioConversionMoneda;

    public ConversorController(ServicioConversionMoneda servicioConversionMoneda)
    {
        this.servicioConversionMoneda = servicioConversionMoneda;
    }
    public async Task<IActionResult> Index()
    {
        var json = await servicioConversionMoneda.ObtenerMonedas();
        return View();
    }
}
