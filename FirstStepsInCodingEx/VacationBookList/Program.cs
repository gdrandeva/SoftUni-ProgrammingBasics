using System;

namespace VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            // read sheets count
            int sheets = int.Parse(Console.ReadLine());

            // sheets per hour

            int sheetsPerHour = int.Parse(Console.ReadLine());

            // days for reading a book

            int days = int.Parse(Console.ReadLine());

            // pring the count of hours for reading the book

            int hoursForBook = sheets / sheetsPerHour;
            int totalHours = hoursForBook / days;

            Console.WriteLine(totalHours);
        }
    }
}
