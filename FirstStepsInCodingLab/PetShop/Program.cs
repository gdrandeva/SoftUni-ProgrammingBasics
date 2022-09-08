using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogFeedPrice = 2.50;
            double catFeedPrice = 4.00;

            int dogFeedCount = int.Parse(Console.ReadLine());
            int catFeedCount = int.Parse(Console.ReadLine());

            double finalPrice = (dogFeedPrice * dogFeedCount) + (catFeedPrice * catFeedCount);

            Console.WriteLine($"{finalPrice} lv.");
        }
    }
}
