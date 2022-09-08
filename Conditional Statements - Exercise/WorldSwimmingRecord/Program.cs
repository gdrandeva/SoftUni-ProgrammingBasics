using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double swimmingRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeMetersSec = double.Parse(Console.ReadLine());
            double addDelay = Math.Round((distance/15) * 12.5);
            double ivanRecord = distance * timeMetersSec + addDelay;

           

            if (swimmingRecord > ivanRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Floor(ivanRecord):F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(ivanRecord-swimmingRecord):F2} seconds slower.");
            }

        }
    }
}
