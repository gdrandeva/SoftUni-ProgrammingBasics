using System;

namespace Tickets2
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

            if (peopleInGroup <= 4)
            {
                transportationCost = budget * 0.75;
            }
            else if (peopleInGroup <= 9)
            {
                transportationCost = budget * 0.6;
            }
            else if (peopleInGroup <= 24)
            {
                transportationCost = budget * 0.5;
            }
            else if (peopleInGroup <= 49)
            {
                transportationCost = budget * 0.4;
            }
            else
            {
                transportationCost = budget * 0.25;
            }

            moneyForTickets = budget - transportationCost;
            int numberOfTicketsVip = (int)moneyForTickets / (int)vip / peopleInGroup;
            int numberOfTicketsNormal = (int)moneyForTickets / (int)normal / peopleInGroup;

            if (numberOfTicketsVip == peopleInGroup && categoryTicket == "vip")
            {
                Console.WriteLine($"Yes! You have {moneyForTickets - (peopleInGroup * vip):f2} leva left.");
            }
            else if (numberOfTicketsVip != peopleInGroup && categoryTicket == "vip")
            {
                Console.WriteLine($"Not enough money! You need {(peopleInGroup * vip - moneyForTickets):f2} leva.");
            }

            if (numberOfTicketsNormal == peopleInGroup && categoryTicket == "normal")
            {

                Console.WriteLine($"Yes! You have {moneyForTickets - (peopleInGroup * normal):f2} leva left.");
            }
            else if (numberOfTicketsNormal != peopleInGroup && categoryTicket == "normal")
            {
                Console.WriteLine($"Not enough money! You need {(peopleInGroup * normal - moneyForTickets):f2} leva.");
            }

        }
    }
}
