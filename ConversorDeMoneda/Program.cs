using System;

namespace MiCalculadoraProyecto
{
    internal class Program
    {/*
        static void Main(string[] args)
        {
            
            Calculadora calculadora = new Calculadora();

            int resultadoSuma = calculadora.Suma(5, 3);
            Console.WriteLine("Resultado de la suma: " + resultadoSuma);

            int resultadoResta = calculadora.Resta(10, 4);
            Console.WriteLine("Resultado de la resta: " + resultadoResta);

            int resultadoMultiplicar = calculadora.Multiplicar(10, 4);
            Console.WriteLine("Resultado de la multiplicación: " + resultadoMultiplicar);

            try
            {
                int resultadoDividir = calculadora.Dividir(10, 2);
                Console.WriteLine("Resultado de la división: " + resultadoDividir);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            ConversorDeMoneda conversor = new ConversorDeMoneda();

            decimal cantidadEnDolares = 100m;
            decimal cantidadEnEuros = conversor.ConvertirDolarAEuro(cantidadEnDolares);
            Console.WriteLine($"{cantidadEnDolares} USD es igual a {cantidadEnEuros} EUR");

            cantidadEnEuros = 85m;
            cantidadEnDolares = conversor.ConvertirEuroADolar(cantidadEnEuros);
            Console.WriteLine($"{cantidadEnEuros} EUR es igual a {cantidadEnDolares} USD");
        }*/

       
    
       
        
            static void Main(string[] args)
            {
                Calculadora calculadora = new Calculadora();

                Console.WriteLine("Ingrese dos números para realizar operaciones aritméticas básicas:");

                Console.Write("Primer número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                int resultadoSuma = calculadora.Suma(num1, num2);
                Console.WriteLine("Resultado de la suma: " + resultadoSuma);

                int resultadoResta = calculadora.Resta(num1, num2);
                Console.WriteLine("Resultado de la resta: " + resultadoResta);

                int resultadoMultiplicar = calculadora.Multiplicar(num1, num2);
                Console.WriteLine("Resultado de la multiplicación: " + resultadoMultiplicar);

                try
                {
                    int resultadoDividir = calculadora.Dividir(num1, num2);
                    Console.WriteLine("Resultado de la división: " + resultadoDividir);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }

                ConversorDeMoneda conversor = new ConversorDeMoneda();

                Console.WriteLine("Ingrese la cantidad de dinero que desea convertir:");
                decimal cantidad = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la moneda de origen (USD o EUR):");
                string monedaOrigen = Console.ReadLine().ToUpper();

                Console.WriteLine("Ingrese la moneda de destino (USD o EUR):");
                string monedaDestino = Console.ReadLine().ToUpper();

                if (monedaOrigen == "USD" && monedaDestino == "EUR")
                {
                    decimal cantidadEnEuros = conversor.ConvertirDolarAEuro(cantidad);
                    Console.WriteLine($"{cantidad} USD es igual a {cantidadEnEuros} EUR");
                }
                else if (monedaOrigen == "EUR" && monedaDestino == "USD")
                {
                    decimal cantidadEnDolares = conversor.ConvertirEuroADolar(cantidad);
                    Console.WriteLine($"{cantidad} EUR es igual a {cantidadEnDolares} USD");
                }
                else
                {
                    Console.WriteLine("Conversión no soportada o monedas iguales.");
                }
            }
        }
    }







    

