﻿using System;

namespace GeneralForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > maxNum)
                {
                    maxNum = num;
                }

            }
            sum = sum - maxNum;
            //int diff = Math.Abs(maxNum - sum);

            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = "+sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = " + Math.Abs(maxNum-sum));
            }
        }
    }
}
