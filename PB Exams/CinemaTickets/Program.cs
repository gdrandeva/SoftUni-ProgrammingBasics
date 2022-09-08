using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int freeSeats = 0;// int.Parse(Console.ReadLine());
            string typeOfTicket;
            int studentTicket = 0;
            int kidTicket = 0;
            int standartTicket = 0;
            int ticketsCounter;
            double studentPercent;
            double standartPercent;
            double kidPercent;

            while (true)
            {
                name = Console.ReadLine();
                if (name == "Finish")
                {

                    break;
                }
                freeSeats = int.Parse(Console.ReadLine());
               
               
                for (int i = freeSeats; i > 0; i--)
                {
                    typeOfTicket = Console.ReadLine();
                    switch (typeOfTicket)
                    {
                        case "standart":
                            standartTicket++;
                            break;
                        case "student":
                            studentTicket++;
                            break;
                        case "kid":
                            kidTicket++;
                            break;
                    }
                    
                }
               
            }


            Console.WriteLine($"{name} - {percentOfEachFilm}% full.");
            double percentOfEachFilm = ticketsCounter / freeSeats * 100;
            ticketsCounter = studentTicket + kidTicket + standartTicket;
            studentPercent = studentTicket / ticketsCounter * 100;
            standartPercent = standartTicket / ticketsCounter * 100;
            kidPercent = kidTicket / ticketsCounter * 100;

            Console.WriteLine($"Total tickets: {ticketsCounter}");
            Console.WriteLine($"{studentPercent}% student tickets.");
            Console.WriteLine($"{standartPercent}% standard tickets.");
            Console.WriteLine($"{kidPercent}% kids tickets.");
        }
    }
}
