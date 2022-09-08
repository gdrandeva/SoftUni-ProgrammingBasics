using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());
            int totalCount = puzzleCount + dollCount + bearCount + minionCount;



            double puzzle = 2.60;
            double doll = 3.00;
            double bear = 4.10;
            double minion = 8.20;
            double truck = 2.00;
            //double discount = 0;

            double puzzlePrice = (puzzleCount * puzzle);
            double dollPrice = (dollCount * doll);
            double bearPrice = (bear * bearCount);
            double minionPrice = (minion * minionCount);
            double truckPrice = (truck * truckCount);

            double totalSumToys = puzzlePrice + dollPrice + bearPrice + minionPrice + truckPrice;

            /*if (totalCount >= 50)
            {
                discount = 0.25 * totalSumToys;
                totalSumToys = totalSumToys - discount;
            }
            totalSumToys = totalSumToys - totalSumToys * 0.10;

            if (totalSumToys >= tripPrice)
            {
                Console.WriteLine($"Yes! {(totalSumToys - tripPrice):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - totalSumToys:F2} lv needed.");
            }*/

            if (totalCount >= 50)
            {
                totalSumToys = totalSumToys - totalSumToys * 0.25;
            }
            totalSumToys = totalSumToys - totalSumToys * 0.10;

            double difference = totalSumToys - tripPrice;

            if (difference >= 0)
            {
                Console.WriteLine($"Yes! {difference:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(difference):F2} lv needed.");
            }
        }
    }
}