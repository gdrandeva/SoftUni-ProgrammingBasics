using System;

namespace EqualSumsEvenOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            string currentNum;
            int currentDigit = 0;

            for (int i = num1; i < num2; i++)
            {
                currentNum = i.ToString();
                for (int j = 0; j < currentNum.Length; j++)
                {
                    currentDigit =
                    {
                        evenSum += currentDigit;
                    }
                    else if (j%2!=0)
                    {
                        oddSum += currentDigit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.WriteLine(i + " ");
                }

            }
            
        }
    }
}
