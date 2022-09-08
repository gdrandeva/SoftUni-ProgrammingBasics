using System;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            // defini radians

            double radians = double.Parse(Console.ReadLine());

            // convert to degrees - градус = радиан * 180 / π. 

            double degrees = radians * 180 / Math.PI;

            // print degrees
            Console.WriteLine(degrees);

           
        }
    }
}
