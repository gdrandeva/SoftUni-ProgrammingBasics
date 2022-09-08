using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 1;
            while (num1 <=10)
            {
                num2 = 1;
                while (num2 <=10)
                {
                    Console.WriteLine($"{num1} * {num2} = {num1*num2}");
                    num2++;
                }
                num1++;
            }
        }
    }
}
