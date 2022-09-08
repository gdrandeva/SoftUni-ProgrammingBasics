using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            string pieceOfCake = "";
            int cakeSize = width * length;
            int cakeCounter = 0;

            while (pieceOfCake != "STOP")
            {
                pieceOfCake = Console.ReadLine();
                if (pieceOfCake == "STOP")
                {
                    Console.WriteLine($"{cakeSize - cakeCounter} pieces are left.");
                    break;
                }
                cakeCounter += int.Parse(pieceOfCake);

                if (cakeCounter<cakeSize)
                {
                    continue;
                }
                else if (cakeCounter>cakeSize)
                {
                    Console.WriteLine($"No more cake left! You need {cakeCounter-cakeSize} pieces more.");
                    break;
                }
               
            }

        }
    }
}
