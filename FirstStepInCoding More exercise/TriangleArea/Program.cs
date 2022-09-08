using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {

            // read a and h

            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            // calculate the triangle are

            double area = a * h / 2;

            // print the result

            Console.WriteLine($"{area:f2}");
        }
    }
}
