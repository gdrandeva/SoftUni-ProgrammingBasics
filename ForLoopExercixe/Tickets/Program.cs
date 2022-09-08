using System;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string categoryTicket = Console.ReadLine();
            categoryTicket = categoryTicket.ToLower();
            int peopleInGroup = int.Parse(Console.ReadLine());
            double transportationCost = 0.0;
            double moneyForTickets = 0.0;
            double vip = 499.99;
            double normal = 249.99;

            switch (peopleInGroup)
            {
                case  <= 4:
                    transportationCost = budget * 0.75;
                    break;
                case <= 9:
                    transportationCost = budget * 0.6;
                    break;
                case <= 24:
                    transportationCost = budget * 0.5;
                    break;
                case <= 49:
                    transportationCost = budget * 0.4;
                    break;
                default:
                    transportationCost = budget * 0.25;
                    break;
            }

            moneyForTickets = budget - transportationCost;
            int numberOfTicketsVip = (int)moneyForTickets / (int)vip / peopleInGroup;
            int numberOfTicketsNormal = (int)moneyForTickets / (int)normal / peopleInGroup;
            switch (categoryTicket)
            {
                case "vip":
                    if (numberOfTicketsVip == peopleInGroup)
                    {
                        Console.WriteLine($"Yes! You have {moneyForTickets-(peopleInGroup*vip):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(peopleInGroup*vip - moneyForTickets):f2} leva.");
                    }
                    break;
                case "normal":
                    if (numberOfTicketsNormal == peopleInGroup)
                    {
                        Console.WriteLine($"Yes! You have {moneyForTickets - (peopleInGroup * normal):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(peopleInGroup * normal - moneyForTickets):f2} leva.");
                    }
                    break;
                default:
                    break;
            }
            
            
        }
    }
}