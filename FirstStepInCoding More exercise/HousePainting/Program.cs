using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            // green paint for walls


            //red paint for a roof

            // paint consumption > green 1l/3.4m2, red 1./4.3m2

            int height = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            double roofH = double.Parse(Console.ReadLine());

            double doorArea = 2 * 1.2;
            double windowArea = 1.5 * 1.5;
            double windowsArea = 2 * windowArea;

            double sideWalls = 2 *(height * lenght) - windowsArea;
            double frontBackSide = 2 * (height*height) - doorArea;
            double wallsPaintQuantity = (sideWalls + frontBackSide) / 3.4;

            double rectagles = 2 * (height * lenght);
            double triangles = 2 * (height * roofH / 2);
            double roofPaintQuantity = (rectagles + triangles) / 4.3;

            Console.WriteLine($"{wallsPaintQuantity:f2}");
            Console.WriteLine($"{roofPaintQuantity:f2}");
        }
    }
}
