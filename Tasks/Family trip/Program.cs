using System;

namespace Family_trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());
            double money;

            money = nights * nightPrice;

            if (nights > 7)
            {
                nightPrice -= nightPrice * 5 / 100;
            }
            money = nightPrice * nights;
            money += budget * percentage / 100;

            if (money >= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {money-budget:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{budget-money:f2} leva needed.");
                    
            }
        }
    }
}
