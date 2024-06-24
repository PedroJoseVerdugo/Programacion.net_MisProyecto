using Microsoft.AspNetCore.Mvc;
using FinalTrabajo.Services;
using System.Threading.Tasks;
using System.Linq;
using FinalTrabajo.Models; 



namespace FinalTrabajo.Controllers
{
    public class ConversorMonedaController : Controller
    {
        private readonly ConversorMonedaConverterService _currencyConverterService;
        private readonly Context _dbContext; 

        public ConversorMonedaController(ConversorMonedaConverterService currencyConverterService, Context dbContext)
        {
            _currencyConverterService = currencyConverterService;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> ConverterAsync()
        {
            var model = new ConversorMonedaConversionViewModel
            {
                ValidCurrencyCodes = await _currencyConverterService.GetCurrencyList()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Converter([Bind("Amount,SourceCurrency,TargetCurrency")] ConversorMonedaConversionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ValidCurrencyCodes = await _currencyConverterService.GetCurrencyList();
                return View(model);
            }

            // Convertir el valor de Amount de string a decimal
            if (!decimal.TryParse(model.Amount.ToString(), out decimal amount))
            {
                ModelState.AddModelError(nameof(model.Amount), "El importe no es válido.");
                model.ValidCurrencyCodes = await _currencyConverterService.GetCurrencyList();
                return View(model);
            }


            //if (!ModelState.IsValid)
            //{
            //    model.ValidCurrencyCodes = await _currencyConverterService.GetCurrencyList();
            //    return View(model);
            //}

            var result = await _currencyConverterService.ConvertCurrency(model.Amount, model.SourceCurrency, model.TargetCurrency);
            model.Result = result;

            var factor = result / model.Amount;

            // Verificar si User.Identity.Name no es null antes de asignarlo
            var usuario = User.Identity.Name ?? "Usuario Desconocido";

            var historico = new Historico
            {
                MonedaOrigen = model.SourceCurrency,
                MonedaDestino = model.TargetCurrency,
                Importe = model.Amount,
                Resultado = result,
                Factor = factor,
                Usuario = usuario, // Asignar usuario o un valor predeterminado si User.Identity.Name es null
                Fecha = DateTime.Now
            };

            _dbContext.Historicos.Add(historico);
            await _dbContext.SaveChangesAsync();

            model.ValidCurrencyCodes = await _currencyConverterService.GetCurrencyList();

            return View(model);
        }



        [HttpGet]
        public IActionResult Historial()
        {
            var lastQueries = _dbContext.Historicos
                .OrderByDescending(q => q.Id)
                .Take(10)
                .Select(h => new ConversorMonedaQuery
                {
                    MonedaOrigen = h.MonedaOrigen,
                    MonedaDestino = h.MonedaDestino,
                    Importe = h.Importe,
                    Resultado = h.Resultado,
                    Factor = h.Factor,
                    Usuario = h.Usuario,
                    Fecha = h.Fecha
                })
                .ToList();

            return View(lastQueries);
        }
    }
}
