using System;

namespace _01._Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string airlineName = Console.ReadLine();
            int soldTicketsAdult = int.Parse(Console.ReadLine());
            int soldTicketsChild = int.Parse(Console.ReadLine());
            double netPrice = double.Parse(Console.ReadLine());
            double serviceTax = double.Parse(Console.ReadLine());


            double adultPrice = soldTicketsAdult * netPrice;
            double childPrice = soldTicketsChild * (netPrice-netPrice*0.7);
            double serviceTaxes = (soldTicketsChild + soldTicketsAdult) * serviceTax;
            double totalSum = adultPrice + childPrice + serviceTaxes;

            double agencyProfit = totalSum * 0.2;
            Console.WriteLine($"The profit of your agency from {airlineName} tickets is {agencyProfit:f2} lv.");

        }
    }
}
