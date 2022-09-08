using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lengthFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());
            int currentBox = 0;
            string action = "";

            int freeSpaceVolume = widthFreeSpace * lengthFreeSpace * heightFreeSpace;

            while (action != "Done")
            {
                
                currentBox = int.Parse(Console.ReadLine());
                freeSpaceVolume -= currentBox;
                if (freeSpaceVolume <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpaceVolume)} Cubic meters more.");
                    continue;
                }

                if (action == "Done")
                {
                    currentBox = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{freeSpaceVolume - currentBox} Cubic meters left.");
                }
            }
            
            
        }





            
    }
}
