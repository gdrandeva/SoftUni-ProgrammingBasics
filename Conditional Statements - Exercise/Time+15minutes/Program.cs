using System;

namespace Time_15minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            int timeInMin = minute + hour * 60;
            timeInMin = timeInMin + 15;

            hour = timeInMin / 60;
            minute = timeInMin % 60;


            // 24:05 => 24:05-24=0:05
            if (hour == 24)
            {
                hour = 0;
            }

            if (minute < 10)
            {
                Console.WriteLine($"{hour}:0{minute}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minute}");

            }


        }
    }
}
