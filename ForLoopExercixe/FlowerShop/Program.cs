using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumQuantity = int.Parse(Console.ReadLine());
            int roseQuantity = int.Parse(Console.ReadLine());
            int tulipQuantity = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            season = season.ToLower();
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
            //double priceAllSeasons = 0.0;
            double totalPrice = 0.0;

            switch (holiday)
            {
                case 'Y':
                    if (season == "spring" || season == "summer")
                    {
                        chrysanthemumPrice = chrysanthemumQuantity * chrysanthemumSprSumm;
                        rosePrice = roseQuantity * roseSprSumm;
                        tulipPrice = tulipQuantity * tulipSprSumm;
                        totalPrice = rosePrice + tulipPrice + chrysanthemumPrice;
                        totalPrice = totalPrice + totalPrice * 0.15;
                        if (season == "spring" && tulipQuantity > 7)
                        {
                            totalPrice = totalPrice - totalPrice * 0.05;
                        }
                        if (chrysanthemumQuantity + roseQuantity + tulipQuantity > 20)
                        {
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }
                    }
                    else if (season == "autumn" || season == "winter")
                    {

                        chrysanthemumPrice = chrysanthemumQuantity * chrysanthemumAutWin;
                        rosePrice = roseQuantity * roseAutWin;
                        tulipPrice = tulipQuantity * tulipAutWin;
                        totalPrice = rosePrice + tulipPrice + chrysanthemumPrice;
                        totalPrice = totalPrice + totalPrice * 0.15;
                        if (season == "winter" && roseQuantity >= 10)
                        {
                            totalPrice = totalPrice - totalPrice * 0.1;
                        }
                        if (chrysanthemumQuantity + roseQuantity + tulipQuantity > 20)
                        {
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }
                    }
                    break;
                case 'N':
                    if (season == "spring" || season == "summer")
                    {
                        chrysanthemumPrice = chrysanthemumQuantity * chrysanthemumSprSumm;
                        rosePrice = roseQuantity * roseSprSumm;
                        tulipPrice = tulipQuantity * tulipSprSumm;
                        totalPrice = chrysanthemumPrice + tulipPrice + rosePrice;
                        if (season == "spring" && tulipQuantity > 7)
                        {
                            totalPrice = totalPrice - totalPrice * 0.05;
                        }
                        if (chrysanthemumQuantity + roseQuantity + tulipQuantity > 20)
                        {
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }

                    }

                    else if (season == "autumn" || season == "winter")
                    {

                        chrysanthemumPrice = chrysanthemumQuantity * chrysanthemumAutWin;
                        rosePrice = roseQuantity * roseAutWin;
                        tulipPrice = tulipQuantity * tulipAutWin;
                        totalPrice = chrysanthemumPrice + tulipPrice + rosePrice;
                        if (season == "winter" && roseQuantity >= 10)
                        {
                            totalPrice = totalPrice - totalPrice * 0.1;
                        }
                        if (chrysanthemumQuantity + roseQuantity + tulipQuantity > 20)
                        {
                            totalPrice = totalPrice - totalPrice * 0.2;
                        }
                    }
                    break;

            }



            totalPrice = totalPrice + arrangingPrice;
            Console.WriteLine($"{totalPrice:f2}");


        }
    }
}
