using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardQuantity = int.Parse(Console.ReadLine());
            int processorQuantity = int.Parse(Console.ReadLine());
            int ramQuantity = int.Parse(Console.ReadLine());

            double videoCardPrice = videoCardQuantity * 250.00;
            double processorPrice = processorQuantity * videoCardPrice * 0.35;
            double ramPrice = ramQuantity * videoCardPrice * 0.10;
            double price = videoCardPrice + processorPrice + ramPrice;

            if (videoCardQuantity > processorQuantity)
            {
                price = price - price * 0.15;
               
            }
            if (price <= budget)
            {
                Console.WriteLine($"You have {budget - price:f2} leva left!");
            }
            else if (price > budget)
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva more!");
            }

        }
    }
}
