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

            /*double lunchDuration = 1/8 * breakDuration;
            double leisureDuration = 1/4 * breakDuration;
            double restTime = breakDuration - (lunchDuration + leisureDuration);*/

            double leisureTime = breakDuration * 5 / 8;

            if (leisureTime >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(leisureTime - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(episodeDuration - leisureTime)} more minutes.");
            }

        }
    }
}
