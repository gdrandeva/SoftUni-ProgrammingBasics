using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            // define paramrtrrs for reading


            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int paintThinner = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());


            double protectiveNylonM2 = 1.50;
            double paintPerLiter = 14.50;
            double paintThinnerPerLiter = 5.00;

            // additional quantity of materials

            double finalPaintPrice = 1.1 * paint * paintPerLiter;
            double finalNylonPrice = (nylon + 2) * protectiveNylonM2;
            double bag = 0.40;
            double paintThinnerPrice = paintThinner * paintThinnerPerLiter;
            double materials = finalNylonPrice + finalPaintPrice + bag + paintThinnerPrice;

            // sum per hour = 30% from all costs

            double workmanPerHour = (30 * materials) / 100;
            double workmanPrice = workmanPerHour * workingHours;

            double finalSum = workmanPrice + materials;

            // print •	"{сумата на всички разходи}"

            Console.WriteLine(finalSum);
        }
    }
}