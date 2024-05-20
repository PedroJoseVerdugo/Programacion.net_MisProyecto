using System;

namespace MiCalculadoraProyecto
{
    public class Calculadora
    {
        public int Suma(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }

        public int Resta(int minuendo, int sustraendo)
        {
            return minuendo - sustraendo;
        }

        public int Multiplicar(int factor1, int factor2)
        {
            return factor1 * factor2;
        }

        public int Dividir(int dividendo, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("El divisor no puede ser cero.");
            }
            return dividendo / divisor;
        }
    }
}
