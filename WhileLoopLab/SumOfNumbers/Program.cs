using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            //while (sum < num)
            //{
            //    sum += int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine(sum);

            while (true)
            {
                if (sum >= num)
                {
                    break;
                }
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }

    }
}
