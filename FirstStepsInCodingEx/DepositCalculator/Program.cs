using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // read deposited sum
            double depositedSum = double.Parse(Console.ReadLine());

            // read the period

            double period = double.Parse(Console.ReadLine());

            // read the yearly rate%

            double percentPerYear = double.Parse(Console.ReadLine());

            // calculate tha final sum сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)

            double finalSum = depositedSum + period * depositedSum * percentPerYear /100  / 12;

            Console.WriteLine(finalSum);
        }
    }
}
