using System;

namespace MovingN
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

           
            string movedBox = "";
            int box = 0;
            int emptySpaceInBoxes = width * length * height;
            int boxCount = 0;

            while (movedBox != "Done")
            {
                movedBox = Console.ReadLine();
                if (movedBox == "Done")
                {
                    Console.WriteLine($"{emptySpaceInBoxes} Cubic meters left.");
                    break;
                }
                box = int.Parse(movedBox);
                boxCount += box;
                emptySpaceInBoxes -= box;

                if (emptySpaceInBoxes < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(emptySpaceInBoxes)} Cubic meters more.");
                    break;
                }
            }
        }
        
    }
}
