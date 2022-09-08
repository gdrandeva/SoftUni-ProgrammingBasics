using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineM2 = int.Parse(Console.ReadLine());
            double grapeM2 = double.Parse(Console.ReadLine());
            int neededLitersWine = int.Parse(Console.ReadLine());
            int workersNumber = int.Parse(Console.ReadLine());


            // За 1 литър вино са нужни 2,5 кг. грозде. 
            double totalGrape = vineM2 * grapeM2;
            double wineArea = totalGrape * 0.40;
            double literWine = wineArea / 2.5;

           

            if (litersWine < neededLitersWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitersWine-litersWine)} liters wine needed.");
            }
        }
    }
}
