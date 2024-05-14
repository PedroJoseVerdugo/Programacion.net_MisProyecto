using Animales;

namespace MundoReal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");




            var happy = new Pinguino();
            happy.color = "oscuro";
            var pingu = new Pinguino();
            pingu.color = "blanco";

            var Alex = new Leones();
            Alex.tieneMelena = true;

            var mariano = new Mono();
            mariano.nombre = "mariano";



        }
    }
}
