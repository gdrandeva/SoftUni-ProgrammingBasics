using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());
            //            Времето за обяд ще бъде 1 / 8 от времето за почивка, а времето за отдих ще бъде 1 / 4 от времето за почивка. 
            //                •	Ако времето е достатъчно да изгледате епизода:
            //            "You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
            //•	Ако времето не Ви е достатъчно:
            //"You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
            double lunchTime = breakDuration / 8.0;
            double restTime = breakDuration / 4.0;
            double timeForSeries = 1.0 *breakDuration - lunchTime - restTime;

            if (timeForSeries >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(timeForSeries - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(episodeDuration - timeForSeries)} more minutes.");
            }

           
        }
    }
}
