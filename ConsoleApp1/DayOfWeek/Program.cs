using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            //•	Premiere – премиерна прожекция, на цена 12.00 лева.
            //•	Normal – стандартна прожекция, на цена 7.50 лева.
            //•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.

            int ticketQuantity = rows * columns;
            double income = 0;
            

            switch (type)
            {
                case "Premiere":
                    income = 12.00 * ticketQuantity;
                    break;
                case "Normal":
                    income = 7.50 * ticketQuantity;
                    break;
                case "Discount":
                    income = 5.00 * ticketQuantity;
                    break;

            }
            Console.WriteLine($"{income:f2} leva.");






        }
    }
}
