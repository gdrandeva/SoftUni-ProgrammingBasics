using System;

namespace EvenOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            int num = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else if (i % 2 != 0)
                {
                    oddSum += num;
                }

                int diff = evenSum - oddSum;
                if (evenSum == oddSum)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {evenSum}");
                }
                else if (evenSum != oddSum)
                {
                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {diff}");
                }

            }
            

        }
    }
}
