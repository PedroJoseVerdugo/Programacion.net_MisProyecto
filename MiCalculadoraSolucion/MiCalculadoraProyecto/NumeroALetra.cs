using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCalculadoraProyecto
{
     class NumeroALetra
    {
        private string NumeroALetrasEntero(long numero)
        {
            if (numero == 0)
                return "";

            if (numero < 20)
                return unidades[numero];

            if (numero < 100)
                return decenas[numero / 10] + (numero % 10 > 0 ? " y " + NumeroALetrasEntero(numero % 10) : "");

            if (numero < 1000)
                return (numero / 100 > 1 ? centenas[numero / 100] + " " : "cien ") + NumeroALetrasEntero(numero % 100);

            if (numero < 1000000)
                return (numero / 1000 == 1 ? "mil " : NumeroALetrasEntero(numero / 1000) + " mil ") + NumeroALetrasEntero(numero % 1000);

            if (numero < 1000000000)
                return NumeroALetrasEntero(numero / 1000000) + " millones " + NumeroALetrasEntero(numero % 1000000);

            return NumeroALetrasEntero(numero / 1000000000) + " mil millones " + NumeroALetrasEntero(numero % 1000000000);
        }

        private static readonly string[] unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
        private static readonly string[] decenas = { "", "", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
        private static readonly string[] centenas = { "", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };
    }

}
}
