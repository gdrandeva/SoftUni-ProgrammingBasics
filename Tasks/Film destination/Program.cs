using System;

namespace Film_destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double dayPrice=0;
            double totalPrice;

            if (destination == "Dubai")
            {
                if (season=="Winter")
                {
                    dayPrice = 45000;
                }
                else if (season == "Summer")
                {
                    dayPrice = 40000;
                }

            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    dayPrice = 17000;
                }
                else if (season == "Summer")
                {
                    dayPrice = 12500;
                }
            }
            else if (destination == "London")
            {
                if (season == "Winter")
                {
                    dayPrice = 24000;
                }
                else if (season == "Summer")
                {
                    dayPrice = 20250;
                }
            }

            totalPrice = dayPrice * days;
            if (destination=="Dubai")
            {
                totalPrice -= totalPrice * 0.3;
            }
            else if (destination=="Sofia")
            {
                totalPrice += totalPrice * 0.25;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget-totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {totalPrice-budget:f2} leva more!");
            }
        }
    }
}
