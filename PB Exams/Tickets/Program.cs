using System;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {


           
            string movieName = Console.ReadLine();
            int freeSeats = 0;// int.Parse(Console.ReadLine()); ;
            string typeOfTicket = "";
            int standartCounter = 0;
            int studentCounter = 0;
            int kidCounter = 0;
            double movieTickets = 0;
            int totalCounter = 0;
            double standartPercent;
            double studentPercent;
            double kidPercent;
           

            while (movieName != "Finish")
            {
               
                freeSeats = int.Parse(Console.ReadLine());
                standartCounter = 0;
                studentCounter = 0;
                kidCounter = 0;
                typeOfTicket = Console.ReadLine();

                for (int i = freeSeats; i > 0 ; i--)
                {
                    typeOfTicket = Console.ReadLine();
                    if (typeOfTicket == "End")
                    {
                        break;
                    }
                    if (typeOfTicket == "standart")
                    {
                        standartCounter++;
                    }
                    else if (typeOfTicket == "student")
                    {
                        studentCounter++;
                    }
                    else if (typeOfTicket == "kid")
                    {
                        kidCounter++;
                    }
                    movieTickets++;
                    typeOfTicket = Console.ReadLine();
                }
                Console.WriteLine($"{movieName} - {movieTickets / freeSeats * 100:f2}% full.");
                
               

            }
            totalCounter = studentCounter + standartCounter + kidCounter;
            standartPercent = standartCounter / freeSeats * 100;
            studentPercent = studentCounter / freeSeats * 100;
            kidPercent = kidCounter / freeSeats * 100;
            //percentOfAll = totalCounter / freeSeats * 100;

            Console.WriteLine($"Total tickets: {totalCounter}");
            Console.WriteLine($"{studentPercent}% student tickets.");
            Console.WriteLine($"{standartPercent}% standard tickets.");
            Console.WriteLine($"{kidPercent}% kids tickets.");
        }
    }
}
