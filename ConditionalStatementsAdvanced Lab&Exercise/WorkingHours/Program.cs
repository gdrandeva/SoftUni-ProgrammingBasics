using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            

            if (dayOfWeek == "Sunday" || hour < 10 || hour >18)
            {
                Console.WriteLine("closed");
            }
            else
            {
                Console.WriteLine("open");
            }
            
               
        }
    }
}
