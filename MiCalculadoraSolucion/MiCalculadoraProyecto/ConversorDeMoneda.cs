using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCalculadoraProyecto
{
    public class ConversorDeMoneda
    {
        private readonly decimal tasaDolarAEuro = 0.85m; // Ejemplo de tasa de cambio
        private readonly decimal tasaEuroADolar = 1.18m; // Ejemplo de tasa de cambio

        public decimal ConvertirDolarAEuro(decimal cantidad)
        {
            return cantidad * tasaDolarAEuro;
        }

        public decimal ConvertirEuroADolar(decimal cantidad)
        {
            return cantidad * tasaEuroADolar;
        }
    }
    









}



