using System;

namespace WebAspnVavio.Model
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public int Edad { get; set; }

        public Animal() // Constructor por defecto
        {
            Edad = CalcularEdad();
        }

        public Animal(string nombre, string especie, DateTime fechaNacimiento, double peso, double altura)
        {
            Nombre = nombre;
            Especie = especie;
            FechaNacimiento = fechaNacimiento;
            Peso = peso;
            Altura = altura;
            Edad = CalcularEdad();
        }

        public void Alimentar(double cantidadComida)
        {
            Peso += cantidadComida;
            Console.WriteLine($"{Nombre} ha sido alimentado con {cantidadComida} kg de comida.");
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Peso: {Peso} kg");
            Console.WriteLine($"Altura: {Altura} m");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine(new string('-', 30)); // Línea separadora
        }

        private int CalcularEdad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear)
                edad--;
            return edad;
        }
    }
}
