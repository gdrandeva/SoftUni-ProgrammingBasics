using System;

namespace FirstStepsInCodingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double usdInBgn = 1.79549;

            double bgn = usd * usdInBgn;

            Console.WriteLine(bgn);
        }
    }
}
