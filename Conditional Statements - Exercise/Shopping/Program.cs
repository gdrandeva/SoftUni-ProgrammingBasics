using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            // chetem 4 vhoda i gi zapemetqvame v 4 promenlivi

            double budget = double.Parse(Console.ReadLine());
            int videocardQuantity = int.Parse(Console.ReadLine());
            int processorsQuantity = int.Parse(Console.ReadLine());
            int ramMemoryQuantity = int.Parse(Console.ReadLine());


            // namirame sumata za videokarti

            double videocardPrice = videocardQuantity * 250;

            // namirame cenata za procesorite


            //sumata za procesorite
            double processorsPrice = processorsQuantity * (videocardPrice * 0.35);
            //cenata za ram

            //sumata za ram
            double ramMemoryPrice = ramMemoryQuantity * (videocardPrice * 0.10);

            double totalPrice = videocardPrice + processorsPrice + ramMemoryPrice;

            if (videocardQuantity > processorsQuantity)
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }

            double difference = budget - totalPrice;

            if (difference >= 0)
            {
                Console.WriteLine($"You have {difference} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva more!");
            }


        }
    }
}
