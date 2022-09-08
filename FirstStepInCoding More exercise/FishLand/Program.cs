using System;

namespace FishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackarelPricePerKg = double.Parse(Console.ReadLine());
            double spratPricePerKg = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double horseMackarelKg = double.Parse(Console.ReadLine());
            int musselsKg = int.Parse(Console.ReadLine());

            double bonitoPrice = mackarelPricePerKg + (mackarelPricePerKg * 0.6);
            double mackarelPrice = spratPricePerKg + (spratPricePerKg * 0.8);
            double musselsPrice = 7.50;

            double totalPrice = (bonitoKg * bonitoPrice) + (horseMackarelKg * mackarelPrice) + (musselsKg * musselsPrice);

            Console.WriteLine($"{totalPrice:f2}");


        }
    }
}
