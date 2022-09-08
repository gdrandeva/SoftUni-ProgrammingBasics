using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());

            int annualRate = 30000; // minutes
            int ownerPlayTimeWorkingDays = 63; //minutes
            int ownerPlayTimeNotWorkingDays = 127; //minutes

            int workingDaysPerYear = 365 - restDays;
            int workingDaysTomPlayTime = workingDaysPerYear * ownerPlayTimeWorkingDays;
            int notWorkingDaysTomPlayTime = restDays * ownerPlayTimeNotWorkingDays;
            int tomPlayTime = workingDaysTomPlayTime + notWorkingDaysTomPlayTime; //minutes

            if (tomPlayTime > annualRate)
            {
                int difference = tomPlayTime - annualRate;
                int differenceH = difference / 60;
                int differenceM = difference % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{differenceH} hours and {differenceM} minutes more for play");
            }
            else
            {
                int difference = annualRate - tomPlayTime;
                int differenceH = difference / 60;
                int differenceM = difference % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{differenceH} hours and {differenceM} minutes less for play");
                
            }
        }
    }
}
