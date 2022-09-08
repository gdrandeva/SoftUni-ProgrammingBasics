using System;

namespace CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {

            //Monday Tuesday Wednesday Thursday    Friday Saturday    Sunday
            //  12      12       14       14          12      16        16

            string dayOfWeek = Console.ReadLine();
            dayOfWeek = dayOfWeek.ToLower();

            if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "friday")
            {
                Console.WriteLine(12);
            }
            else if (dayOfWeek == "wednesday" || dayOfWeek == "thursday")
            {
                Console.WriteLine(14);
            }
            else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
            {
                Console.WriteLine(16);
            }
        }
    }
}
