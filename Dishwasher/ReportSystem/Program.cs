using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyForDonation = int.Parse(Console.ReadLine());
            string productPrice = "";
            int productCounter = 0;
            int cashPay = 0;
            int cardPay = 0;
            int sum = 0;
            int averageCS = 0;
            int averageCC = 0;


            while (productPrice != "End")
            {
                productPrice = Console.ReadLine();
                if (productPrice == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }
                int pricePerProduct = int.Parse(productPrice);
                productCounter++;
                if (productCounter % 2 == 0)
                {
                    if (pricePerProduct < 10)
                    {
                        cardPay++;
                        sum += pricePerProduct;
                        averageCC = sum / cardPay;
                        Console.WriteLine("Product sold!");
                    }
                    else if (pricePerProduct > 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }

                }
                else
                {
                    if (pricePerProduct > 100)
                    {
                        cashPay++;
                        sum += pricePerProduct;
                        averageCS = sum / cashPay;
                        Console.WriteLine("Product sold!");
                    }
                    else if (pricePerProduct < 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }

                }

                if (pricePerProduct >= moneyForDonation)
                {
                    Console.WriteLine($"Average CS: {averageCS}");
                    Console.WriteLine($"Average CC: {averageCC}");
                }


            }
        }
    }
}
