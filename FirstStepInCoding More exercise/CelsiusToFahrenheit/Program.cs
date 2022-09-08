using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            // read degrees
            double celsius = double.Parse(Console.ReadLine());


            // convert to Fahrenheit ->  (°C * 1.8) + 32 = °F

            double degreesF = (celsius * 1.8) + 32;

            // print up to second sign after decimal

            Console.WriteLine($"{degreesF:f2}");
        }
    }
}
