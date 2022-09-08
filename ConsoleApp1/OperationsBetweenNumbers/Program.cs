using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operator = char.Parse(Console.ReadLine());

            string evenOrOdd = "odd";
            double result = 0;

            if (operator == '+' || '-' || '*')
            {
                string evenOrOdd = "odd";
                if (operator == '+')
                {
                    result = num1 + num2;
                }
                else if (operator == '-')
                {
                    result = num1 - num2;
                }
                else
                {
                    result = num1 * num2;
                }
            }
            else if (operator == '/')
            {

            }
            else if (operator == '%')
            {
                evenOrOdd = "even";
            }
            
            
            
            Console.WriteLine($"{num1} {operator} {num2} = {result} - {evenOrOdd}"); 
        }
    }
}
