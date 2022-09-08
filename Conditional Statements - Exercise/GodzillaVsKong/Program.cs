using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extraNum = int.Parse(Console.ReadLine());
            double outfitPricePerPerson = double.Parse(Console.ReadLine());

            double discount = 0;
            double decor = budget * 0.10;
            double outfitPriceAll = extraNum * outfitPricePerPerson;
          
            if (extraNum > 150)
            {
                discount = outfitPricePerPerson * 0.10;
               
            }

            double outfitPriceDiscount = outfitPriceAll - extraNum * discount;
            double finalSum = decor + outfitPriceDiscount;

            if (finalSum > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {finalSum-budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - finalSum:f2} leva left.");
            }
         
            
        }
    }
}
