using System;

namespace SwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSec = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSec = double.Parse(Console.ReadLine());

            // съпротивлението на водата го забавя на всеки 15 м. с 12.5 секунди

            double addDelay = Math.Floor(distanceMeters / 15);
            double delay = addDelay * 12.5;
            double distanceTime = distanceMeters * timeSec + delay;
            //            •	Ако Иван е подобрил Световния рекорд(времето му е по-малко от рекорда) отпечатваме:
            //            o   " Yes, he succeeded! The new world record is {времето на Иван} seconds."
            //•	Ако НЕ е подобрил рекорда(времето му е по - голямо или равно на рекорда) отпечатваме:
            //            o   "No, he failed! He was {недостигащите секунди} seconds slower."

            if (distanceTime < recordSec)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {distanceTime:f2} seconds.");
            }
            else if (distanceTime >= recordSec)
            {
                Console.WriteLine($"No, he failed! He was {distanceTime - recordSec:f2} seconds slower.");
            }
            

        }
    }
}
