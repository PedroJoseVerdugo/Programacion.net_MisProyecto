using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCalculadoraProyecto
{
    public class Calculadora
    {
        public int suma(int sumando1, int sumando2)
        {
            int resultadoSuma = sumando1 + sumando2;
            return resultadoSuma;
        }

        public int resta(int minuendo, int sustraendo)
        { 
            int resultadoResta = minuendo - sustraendo;
            return resultadoResta;
        }
        public int multiplicar(int n3, int n4)
        {
            int resultadoMultiplicar = n3 * n4;
            return resultadoMultiplicar;
        }

        public int Dividir(int n1, int n2)
        {
            int resultadoDividir = n1 / n2;
            return resultadoDividir;
        }
    }
}
