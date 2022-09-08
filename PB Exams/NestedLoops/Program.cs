using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3ways to break out of nested loops:
            // 1. bool flag
            // 2.
            // 3.
            //for (int hour = 0; hour <= 23; hour++)
            //{
            //    for (int min = 0; min <= 59; min++)
            //    {
            //        Console.WriteLine($"{hour:d2}:{min:d2}");

            //    }
            //}

            for (int num1 = 1; num1 <= 10; num1++)
            {
                for (int num2 = 1; num2 <= 10; num2++)
                {
                    Console.WriteLine($"{num1}*{num2}={num1*num2}");
                }
            }
        }
    }
}
