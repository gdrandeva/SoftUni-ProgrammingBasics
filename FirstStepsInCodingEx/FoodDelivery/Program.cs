using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegeterianMenu = 8.15;
            double delivery = 2.50;

            int chickenMenuCount = int.Parse(Console.ReadLine());
            int fishMenuCount = int.Parse(Console.ReadLine());
            int vegeterianMenuCount = int.Parse(Console.ReadLine());



            double order = (chickenMenu * chickenMenuCount) + (fishMenu * fishMenuCount) + (vegeterianMenu * vegeterianMenuCount);
            double dessert = (20 * order) / 100;
            double finalOrder = order + dessert + delivery;

            Console.WriteLine(finalOrder);


        }
    }
}
