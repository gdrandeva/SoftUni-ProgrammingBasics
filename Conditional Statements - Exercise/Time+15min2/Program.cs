using System;

namespace Time_15min2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            TimeSpan hourConverted = TimeSpan.FromHours(hour);
            TimeSpan minuteConverted = TimeSpan.FromMinutes(minute);
            TimeSpan totalTime = hourConverted + minuteConverted;
            //TimeSpan totalTimePlus = totalTime + TimeSpan.FromMinutes(15);
            TimeSpan minAdd = minuteConverted + TimeSpan.FromMinutes(15);


            if (hourConverted == 24)
            {
               hour = 0;
            }
            if (minuteConverted < 10)
            {
                Console.WriteLine($"{hourConverted}:0{minuteConverted}");
            }
            else
            {
                Console.WriteLine($"{hourConverted}:{minuteConverted}");
            }
            



        }
    }
}
