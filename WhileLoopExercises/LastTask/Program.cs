using System;

namespace LastTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vacantSeatsEachProjection = int.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine(); ;
            int ticketCounter = 0;
            double occupancyHall=0;

            while (true)
            {
               
                while (ticketType!="End")
                {
                    
                    ticketCounter++;
                    if (ticketCounter<vacantSeatsEachProjection)
                    {
                        ticketType = Console.ReadLine();
                    }
                    else if (ticketCounter>vacantSeatsEachProjection)
                    {
                        break;
                    }
                    occupancyHall = ticketCounter*1.0 / vacantSeatsEachProjection * 100;
                }
                Console.WriteLine($"{input} - {occupancyHall}% full.");
            input = Console.ReadLine();
                if (input == "Finish")
                {
                    break;
                }
                vacantSeatsEachProjection = int.Parse(Console.ReadLine());
            ticketType = Console.ReadLine();
            ticketCounter = 0;
               
            }

        }
    }
}
