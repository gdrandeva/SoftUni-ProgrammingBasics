using System;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleInGroup = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int transportCards = int.Parse(Console.ReadLine());
            int museumTickets = int.Parse(Console.ReadLine());

            int nightPrice = 20*nights;
            double cardPrice = 1.60*transportCards;
            int ticketPrice = 6*museumTickets;

            double totalSum = (nightPrice + cardPrice + ticketPrice)*peopleInGroup;
            totalSum+= totalSum * 0.25;

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
