using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationTrabajoFinalMvc.Models.Servicios;
using WebApplicationTrabajoFinalMvc.ViewModels;

namespace WebApplicationTrabajoFinalMvc.Controllers
{
    public class ConversorController : Controller
    {
        private readonly ServicioConversionMoneda _servicioConversionMoneda;

        public ConversorController(ServicioConversionMoneda servicioConversionMoneda)
        {
            _servicioConversionMoneda = servicioConversionMoneda;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<string> listaMonedas = await _servicioConversionMoneda.ObtenerMonedas();

            var vm = new ConversorIndexViewModel()
            {
                ListaMonedas = listaMonedas
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ConversorIndexViewModel vm)
        {
            List<string> listaMonedas = await _servicioConversionMoneda.ObtenerMonedas();
            vm.ListaMonedas = listaMonedas;

            vm.resultado = await _servicioConversionMoneda.Conversion(vm.monedaOrigen, vm.monedaDestino, vm.importe);

            return View(vm);
        }
    }
}
