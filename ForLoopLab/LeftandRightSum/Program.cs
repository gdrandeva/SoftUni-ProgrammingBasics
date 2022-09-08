using System;

namespace LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int diff = 0;

            for (int i = 0; i < n; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < n; i++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                diff = leftSum - rightSum;
                Console.WriteLine($"No, diff = {Math.Abs(diff)}");
            }
        }
    }
}
