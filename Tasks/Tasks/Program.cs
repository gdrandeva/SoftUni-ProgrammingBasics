using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //int days = int.Parse(Console.ReadLine());
            //double food = double.Parse(Console.ReadLine());

            //double dogFood=0;
            //double catFood=0;
            //double biscuits = 0;
            //double dailyDogFood;
            //double dailyCatFood;

            //for (int today = 1; today <= days; today++)
            //{
            //    dailyDogFood = double.Parse(Console.ReadLine());
            //    dailyCatFood = double.Parse(Console.ReadLine());

            //    if (today % 3 == 0)
            //    {
            //        biscuits += (dailyDogFood + dailyCatFood) / 10;
            //    }
            //    dogFood += dailyDogFood;
            //    catFood += dailyCatFood;
            //}
            //Console.WriteLine($"Total eaten biscuits: {biscuits:f0}gr.");
            //Console.WriteLine($"{ (dogFood + catFood) * 100 / food:f2}% of the food has been eaten.");
            //Console.WriteLine($"{dogFood * 100 / (catFood + dogFood):f2}% eaten from the dog."); 
            //Console.WriteLine($"{catFood * 100 / (catFood + dogFood):f2}% eaten from the cat."); 

            int possibleSales = 356 % 10;
            Console.WriteLine(possibleSales);
        }
    }
}
