﻿using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            // square, rectangle, circle, triangle

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine($"{area:f3}");
            }
            if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = r * r * Math.PI;
                Console.WriteLine($"{area:f3}");
            }
            if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                double area = a * ha / 2;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
