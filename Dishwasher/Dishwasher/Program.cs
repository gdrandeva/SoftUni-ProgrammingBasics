using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottleDetergent = int.Parse(Console.ReadLine());
            string forWashing = "";//Console.ReadLine().ToLower();
            int dishes = 0;
            int cleanPlate = 0;
            int cleanPot = 0;
            int detergentMl = bottleDetergent*750;
            int plateDetergent = 5;
            int potDetergent = 15;
            int washCounter = 0;

            while (forWashing != "End")
            {
                forWashing = Console.ReadLine();
                if (forWashing == "End")
                {
                    Console.WriteLine("Detergent was enough!"); 
                    Console.WriteLine($"{cleanPlate} dishes and {cleanPot} pots were washed."); 
                    Console.WriteLine($"Leftover detergent {detergentMl} ml.");
                    break;
                }
                dishes = int.Parse(forWashing);
                washCounter++;
                if (washCounter %3==0)
                {
                    detergentMl -= (dishes * potDetergent);
                    if (detergentMl < 0)
                    {
                        Console.WriteLine($"Not enough detergent, {Math.Abs(detergentMl)} ml. more necessary!");
                        break;
                    }
                    cleanPot += dishes;
                   continue;
                }
                detergentMl -= (dishes * plateDetergent);
                cleanPlate+=dishes;
            }
            
        }

    }
}
