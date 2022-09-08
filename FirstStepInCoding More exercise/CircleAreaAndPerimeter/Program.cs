using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double circleArea = r * r * Math.PI;
            double circlePerimeter = 2 * Math.PI * r;

            Console.WriteLine($"{circleArea:f2}");
            Console.WriteLine($"{circlePerimeter:f2}");
        }
    }
}
