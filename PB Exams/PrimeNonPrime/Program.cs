using System;

namespace PrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int num;// = Console.ReadLine();
            int sumPrime=0;
            int sumComposite=0;

            while (input != "stop")
            {
                num = int.Parse(input);

                if (num<0)
                {
                    Console.WriteLine("Number is negative");
                    continue;
                }
                if (num%2==0 && num/1==num)
                {
                    sumComposite += num;
                }
                else
                {
                    sumComposite += num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");

            Console.WriteLine($"Sum of all non prime numbers is: {sumComposite}");
        }
    }
}
