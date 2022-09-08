using System;

namespace Excursion_sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaExcursion = int.Parse(Console.ReadLine());
            int mountainExcursion = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();  // stop, sea, mountain
            double profit=0;
            int packetPrice=0;

            while (input!="Stop")
            {
                if (input == "sea")
                {
                    if (seaExcursion>0)
                    {
                        seaExcursion--;
                        packetPrice = 680;
                        profit += packetPrice;
                    }
                    
                }
                else if (input == "mountain")
                {
                    if (mountainExcursion>0)
                    {
                        mountainExcursion--;
                        packetPrice = 499;
                        profit += packetPrice;
                    }
                }
                if (seaExcursion==0 && mountainExcursion==0)
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
