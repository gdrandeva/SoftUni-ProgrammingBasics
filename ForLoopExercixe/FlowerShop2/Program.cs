using System;

namespace FlowerShop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumQuantity = int.Parse(Console.ReadLine());
            int roseQuantity = int.Parse(Console.ReadLine());
            int tulipQuantity = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            double arrangingPrice = 2.0;
            double chrysanthemumSprSumm = 2.00;
            double chrysanthemumAutWin = 3.75;
            double roseSprSumm = 4.10;
            double roseAutWin = 4.50;
            double tulipSprSumm = 2.50;
            double tulipAutWin = 4.15;
            double chrysanthemumPrice = 0.0;
            double rosePrice = 0.0;
            double tulipPrice = 0.0;
            double priceAllSeasons = 0.0;
            double totalPrice = 0.0;

            if (holiday == 'y' && season == "spring" && tulipQuantity > 7 || season == "summer")
            {
                chrysanthemumPrice = chrysanthemumQuantity * chrysanthemumSprSumm;
                rosePrice = roseQuantity * roseSprSumm;
                tulipPrice = tulipQuantity * tulipSprSumm;
                totalPrice = chrysanthemumPrice + rosePrice + tulipPrice;
                totalPrice = totalPrice + 0.15 * totalPrice;
            }
            if (tulipQuantity > 7 && season == "spring")
            {
                totalPrice = totalPrice - totalPrice * 0.05;
                            }
            totalPrice = totalPrice + arrangingPrice;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
