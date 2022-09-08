using System;

namespace Sum_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            int magicCount = 0;
            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    counter++;
                    if (i+j==magicNum)
                    {
                        magicCount++;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
                        if (magicCount==1)
                        { 
                            return;
                        } 
                    }
                    continue;
                }
            }

            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");

        }
    }
}
