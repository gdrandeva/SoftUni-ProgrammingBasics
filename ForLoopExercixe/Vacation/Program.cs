using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            season = season.ToLower();
            double price = 0.0;
            string location = "";
            string accomodation = "";

            if (budget <= 1000)
            {
                accomodation = "Camp";
                if (season == "summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                accomodation = "Hut";
                if (season == "summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else if (season == "winter")
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }
            }
            else if (budget > 3000)
            {
                accomodation = "Hotel";
                
                if (season == "summer")
                {
                    location = "Alaska";
                    price = budget * 0.90;
                }
                else if (season == "winter")
                {
                    location = "Morocco";
                    price = budget * 0.90;
                }
            }
            Console.WriteLine($"{location} - {accomodation} - {price:f2}"); 
        }
    }
}
