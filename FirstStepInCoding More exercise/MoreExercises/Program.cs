using System;

namespace MoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // read b1 , b2 and h

            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());


            // calculate the trapeziod area

            double trapeziodArea = (b1 + b2) * h  / 2;

            Console.WriteLine($"{trapeziodArea:f2}");
        }
    }
}
