namespace MiCalculadoraProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            int resultadoSuma = calculadora.suma(5, 3);
            Console.WriteLine("Resultado de la suma: " + resultadoSuma);

            int resultadoResta = calculadora.resta(10, 4);
            Console.WriteLine("Resultado de la resta: " + resultadoResta);

            int resultadomultiplicar = calculadora.multiplicar(10, 4);
            Console.WriteLine("Resultado de la multiplicaciòn: " + resultadomultiplicar);

            int resultadoDividir = calculadora.Dividir(10, 2);
            Console.WriteLine("Resultado de la Dividisiòn: " + resultadoDividir);

                  /*                       */
            

            var calculadoraa = new Calculadora();

            var suma = calculadora.suma(3, 3);
            Console.WriteLine("Resultado de la suma: " + suma);

            var resta = calculadora.resta(60, 40);
            Console.WriteLine("Resultado de la resta: " + resta);

            var multiplicar = calculadora.multiplicar(10, 4);
            Console.WriteLine("Resultado de la multiplicación: " + multiplicar);

            var Dividir = calculadora.Dividir(10, 2);
            Console.WriteLine("Resultado de la división: " + Dividir);
            




        }
    }
}
