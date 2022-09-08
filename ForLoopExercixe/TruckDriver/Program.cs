using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            double salary = 0.0;
            double kmSeason5000SaPrice = 4 * 0.75;
            double kmSeason10000SaPrice = 4 * 0.95;
            double kmSeason20000Price = 4 * 1.45;
            double kmSeason5000SummPrice = 4 * 0.90;
            double kmSeason10000SummPrice = 4 * 1.1;
            double kmSeason5000WPrice = 4 * 1.05;
            double kmSeason10000WummPrice = 4 * 1.25;
            double tax = 0.0;

            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (kmPerMonth <= 5000)
                    {
                        salary = kmPerMonth * kmSeason5000SaPrice;
                    }
                    else if (kmPerMonth <= 10000)
                    {
                        salary = kmPerMonth * kmSeason10000SaPrice;
                    }
                    else if (kmPerMonth <= 20000)
                    {
                        salary = kmPerMonth * kmSeason20000Price;
                    }
                    break;
                case "Summer":
                    if (kmPerMonth <= 5000)
                    {
                        salary = kmPerMonth * kmSeason5000SummPrice;
                    }
                    else if (kmPerMonth <= 10000)
                    {
                        salary = kmPerMonth * kmSeason10000SummPrice;
                    }
                    else if (kmPerMonth <= 20000)
                    {
                        salary = kmPerMonth * kmSeason20000Price;
                    }
                    break;
                case "Winter":
                    if (kmPerMonth <= 5000)
                    {
                        salary = kmPerMonth * kmSeason5000WPrice;
                    }
                    else if (kmPerMonth <= 10000)
                    {
                        salary = kmPerMonth * kmSeason10000WummPrice;
                    }
                    else if (kmPerMonth <= 20000)
                    {
                        salary = kmPerMonth * kmSeason20000Price;
                    }
                    break;                

            }
           
            tax = salary * 0.1;
            salary = salary - tax;
            Console.WriteLine($"{salary:f2}");
        }
    }
}
