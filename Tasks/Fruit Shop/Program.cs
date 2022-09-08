using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPriceKg = int.Parse(Console.ReadLine());
            double bananasKg = double.Parse(Console.ReadLine());
            double orangesKg = double.Parse(Console.ReadLine());
            double raspberriesKg = double.Parse(Console.ReadLine());
            double strawberriesKg = double.Parse(Console.ReadLine());

            double strawberries = strawberriesKg * strawberriesPriceKg;
            double raspberries = strawberries * 0.5*raspberriesKg;
            double oranges = raspberries - raspberries * 0.4*orangesKg;
            double bananas = raspberries - raspberries * 0.8*bananasKg;

            double totalPrice = strawberries + raspberries + oranges + bananas;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
