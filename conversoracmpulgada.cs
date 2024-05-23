using System;

namespace staticDemoPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;

            while (selection != "q" && selection != "Q")
            {
                Console.Write("Enter C)elsius to Fahrenheit, F)ahrenheit to Celsius, I)nches to Centimeters, C)entimeters to Inches or Q)uit: ");

                selection = Console.ReadLine();
                double fahrenheit, celsius, centimeters, inches = 0;

                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Please enter the Celsius temperature: ");
                        fahrenheit = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:f2}");
                        break;

                    case "F":
                    case "f":
                        Console.Write("Please enter the Fahrenheit temperature: ");
                        celsius = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius: {celsius:f2}");
                        break;

                    case "I":
                    case "i":
                        Console.Write("Please enter the Inches: ");
                        centimeters = TemperatureConverter.InchesToCentimeters(Console.ReadLine());
                        Console.WriteLine($"Measurement in Centimeters: {centimeters:f2}");
                        break;

                    case "L":
                    case "l":
                        Console.Write("Please enter the Centimeters: ");
                        inches = TemperatureConverter.CentimetersToInches(Console.ReadLine());
                        Console.WriteLine($"Measurement in Inches: {inches:f2}");
                        break;

                    case "q":
                    case "Q":
                        break;

                    default:
                        Console.WriteLine("Please try again.");
                        break;
                }
            }
        }
    }
}
