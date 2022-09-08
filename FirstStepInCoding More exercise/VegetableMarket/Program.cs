using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            // read price per kg for vegetables, fruits; total kg of vegetables, fruits
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int totalKgVeg = int.Parse(Console.ReadLine());
            int totalKgFruits = int.Parse(Console.ReadLine());

            // total sum of earnings and of expenses
            double totalSum = (vegetablesPrice * totalKgVeg) + (fruitsPrice * totalKgFruits);

            // convert to EUR 
            double totalSumEur = totalSum / 1.94;

            // print the result as format it up to the second sign after decimal
            Console.WriteLine($"{totalSumEur:f2}");
        }
    }
}
