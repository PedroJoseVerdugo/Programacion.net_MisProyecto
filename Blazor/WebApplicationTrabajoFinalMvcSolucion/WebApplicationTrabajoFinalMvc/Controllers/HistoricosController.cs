using Microsoft.AspNetCore.Mvc;
using WebApplicationTrabajoFinalMvc.Models;

namespace WebApplicationTrabajoFinalMvc.Controllers
{
    public class HistoricosController : Controller
    {
        public IActionResult MostrarHistorico()
        {
            var historico = new Historico();
            historico.Id = "";
            historico.MonedaOrigen = "";
            historico.MonedaDestino = "";
            historico.Importe = "";
            historico.Resultado = "";
            historico.Fecha = new DateTime(2024, 6, 1);
            historico.Factor = "";
            historico.Usuario = "";

            return View(historico);
        }
    }
}
