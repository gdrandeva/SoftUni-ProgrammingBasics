using System;

namespace AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double luggagePrice = double.Parse(Console.ReadLine());
            double luggageKg = double.Parse(Console.ReadLine());
            int daysTo = int.Parse(Console.ReadLine());
            int numberOfBoxes = int.Parse(Console.ReadLine());
            double tax = 0.0;

            if (luggageKg < 10)
            {
                tax = luggagePrice * 0.2*numberOfBoxes;
            }
            else if (luggageKg <= 20)
            {
                tax = luggagePrice * 0.5*numberOfBoxes;
            }
            else if (luggageKg > 20)
            {
                tax = double.Parse(Console.ReadLine()) * luggageKg*numberOfBoxes;
            }

            if (daysTo>30)
            {
                tax += 0.1 * tax;
            }
            else if (daysTo>7 || daysTo<=30)
            {
                tax += 0.15 * tax;
            }
            else if (daysTo<7)
            {
                tax += 0.4 * tax;
            }

            Console.WriteLine($" The total price of bags is: {tax:f2} lv. ");
        }
    }
}
