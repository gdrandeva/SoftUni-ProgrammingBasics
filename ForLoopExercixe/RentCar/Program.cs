using System;

namespace RentCar
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            season = season.ToLower();
            double price = 0.0;
            string car = " ";

            switch (season)
            {
                case "summer":
                    car = "Cabrio";
                    if (budget <= 100)
                    {
                        price = budget * 0.35;
                        Console.WriteLine("Economy class");
                        Console.WriteLine($"{car} - {price:f2}");

                    }
                    else if (budget <= 500)
                    {
                        price = budget * 0.45;
                        Console.WriteLine("Compact class");
                        Console.WriteLine($"{car} - {price:f2}");

                    }
                    break;
                case "winter":
                    car = "Jeep";
                    if (budget <= 100)
                    {
                        price = budget * 0.65;
                        Console.WriteLine("Economy class");
                        Console.WriteLine($"{car} - {price:f2}");

                    }
                    else if (budget <= 500)
                    {
                        price = budget * 0.80;
                        Console.WriteLine("Compact class");
                        Console.WriteLine($"{car} - {price:f2}");

                    }
                    break;
                   

            }
            if (budget > 500)
            {
                car = "Jeep";
                price = budget * 0.90;
                Console.WriteLine("Luxury class");
                Console.WriteLine($"{car} - {price:f2}");
            }


        }
    }
}
