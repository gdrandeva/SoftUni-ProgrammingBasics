using System;

namespace _1st_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double water = (pipe1 + pipe2) * hours;

            if (water < volume)
            {
                double poolPercent = water / volume * 100;
                double pipe1Percent = pipe1 * hours / water * 100;
                double pipe2Percent = pipe2 * hours / water * 100;
                Console.WriteLine($"The pool is {poolPercent:f2}% full. Pipe 1: {pipe1Percent:f2}%. Pipe 2: {pipe2Percent:f2}%.");
            }
            else
            {
                double moreWater = water - volume;
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {moreWater:f2} liters.");
            }








        }
    }
}
