using System;

namespace staticDemoPractice
{
    public class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string tempCelsius)
        {
            double celsius = double.Parse(tempCelsius);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string tempFahrenheit)
        {
            double fahrenheit = double.Parse(tempFahrenheit);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }

        public static double InchesToCentimeters(string inches)
        {
            double inchesValue = double.Parse(inches);
            double centimeters = inchesValue * 2.54;
            return centimeters;
        }

        public static double CentimetersToInches(string centimeters)
        {
            double centimetersValue = double.Parse(centimeters);
            double inches = centimetersValue / 2.54;
            return inches;
        }
    }
}
