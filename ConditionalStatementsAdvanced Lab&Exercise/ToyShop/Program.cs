using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleQuantity = int.Parse(Console.ReadLine());
            int dollQuantity = int.Parse(Console.ReadLine());
            int bearQuantity = int.Parse(Console.ReadLine());
            int minionQuantity = int.Parse(Console.ReadLine());            
            int truckQuantity = int.Parse(Console.ReadLine());

            double puzzlePrice = puzzleQuantity * 2.60;
            double dollPrice = dollQuantity * 3.00;
            double bearPrice = bearQuantity * 4.10;
            double minionPrice = minionQuantity * 8.20;            
            double truckPrice = truckQuantity * 2.00;

            double totalPrice = puzzlePrice + dollPrice + minionPrice + bearPrice + truckPrice;
            double rent = 0.0;
            if (puzzleQuantity + dollQuantity + minionQuantity + bearQuantity + truckQuantity >= 50)
            {
                totalPrice =  totalPrice -totalPrice * 0.25;
                rent = totalPrice * 0.10;
                totalPrice = totalPrice - rent;
            }
            else if (puzzleQuantity + dollQuantity + minionQuantity + bearQuantity + truckQuantity < 50)
                {
                rent = totalPrice * 0.10;
                totalPrice = totalPrice - rent;                
                }
            if (totalPrice > tripPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(totalPrice - tripPrice):f2} lv needed.");

            }

        }

    }
}
