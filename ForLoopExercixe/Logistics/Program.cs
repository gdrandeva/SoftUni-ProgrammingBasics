using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGoods = int.Parse(Console.ReadLine());
            int weight = 0;
            int price = 0;
            int minibusPrice = 200;
            int truckPrice = 175;
            int train = 120;
            string vehicle = "";
            int totalWeight = 0;


            for (int i = 0; i < numberOfGoods; i++)
            {
                weight = int.Parse(Console.ReadLine());

                if (weight <= 3)
                {
                    vehicle = "minibus";
                    price = minibusPrice;
                    totalWeight += weight;
                }
                else if (weight <= 11)
                {
                    vehicle = "truck";
                    price = truckPrice;
                    totalWeight += weight;
                }
                else if (weight > 12)
                {
                    vehicle = "train";
                    price = train;
                    totalWeight += weight;
                }
            }
            price = price * weight;
            double avgPrice = price / numberOfGoods;
            double percent = weight / totalWeight * 100;
        }
    }
}
