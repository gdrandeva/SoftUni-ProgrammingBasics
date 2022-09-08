using System;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            //for (int i = 0; i <=n; i+=2)//3
            //{
            //    Console.WriteLine(Math.Pow(2,i));
            //}

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2,i));
                }
            }
        }
    }
}