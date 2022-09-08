using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            season = season.ToLower();
            

            //            При 100лв.или по-малко – някъде в България
            //        o   Лято – 30 % от бюджета
            //        o   Зима – 70 % от бюджета
            //•	При 1000лв.или по малко – някъде на Балканите
            //o   Лято – 40 % от бюджета
            //o   Зима – 80 % от бюджета
            //•	При повече от 1000лв. – някъде из Европа
            //o   При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.
            string typeVacation = string.Empty;

            string destination = string.Empty;
            


            //if (season == "Summer")
            //{
            //    typeVacation = "Camp";
            //    if (budget <= 100)
            //    {
            //        price = budget * 0.3;
            //        Console.WriteLine(price);
            //    }
            //}

            if (budget <= 100)
            {
                destination = "Bulgaria";


                if (season == "summer")
                {
                    typeVacation = "Camp";
                    budget = budget * 0.3;
                }
                else // if (season == "winter")
                {
                    typeVacation = "Hotel";
                    budget = budget * 0.7;
                }
                //Console.WriteLine($"Somewhere in {destination}");
                //Console.WriteLine($"{typeVacation} - {budget:f2}");

            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";


                if (season == "summer")
                {
                    typeVacation = "Camp";
                    budget = budget * 0.4;
                }
                else // if (season == "winter")
                {
                    typeVacation = "Hotel";
                    budget = budget * 0.8;
                }
                //Console.WriteLine($"Somewhere in {destination}");
                //Console.WriteLine($"{typeVacation} - {budget:f2}");
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                typeVacation = "Hotel";
                budget = budget * 0.9;                
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeVacation} - {budget:f2}");
        }
    }
}
