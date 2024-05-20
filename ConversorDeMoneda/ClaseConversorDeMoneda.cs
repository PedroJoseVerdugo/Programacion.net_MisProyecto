using System;

namespace MiCalculadoraProyecto
{
    public class ConversorDeMoneda
    {
        private readonly decimal tasaDolarAEuro = 0.85m; 
        private readonly decimal tasaEuroADolar = 1.18m;    

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
