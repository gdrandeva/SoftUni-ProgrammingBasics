using System;

namespace MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Negative number!");
                    break;                    
                }


                num = num * 2;
                Console.WriteLine($"Result: {num:f2}");
                
               
            }
        }
    }
}
