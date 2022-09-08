using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour=0;
            int minute=0;
            while (hour<=23)
            {
                minute = 0;
                while (minute <=59)
                {
                    Console.WriteLine($"{hour}:{minute}");
                    minute++;
                   
                }
                hour++;
            }
        }
    }
}
