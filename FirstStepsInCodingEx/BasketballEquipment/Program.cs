using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // read annual tax

            int annualTax = int.Parse(Console.ReadLine());
            // basketball shoes = 40% discount than annual tax

            double basketballShoes = annualTax - (0.4 * annualTax);

            // basketball outfit = 20% discount than shoes

            double basketballOutfit = basketballShoes - (0.2 * basketballShoes);
            // basketball ball

            double basketballBall = 0.25 * basketballOutfit;

            // basketball accessories = 1/5 discount than basketball ball

            double basketballAcc = 0.2 * basketballBall;
      

            //print all costs
            double costs = basketballShoes + basketballOutfit + basketballAcc + basketballBall + annualTax;
            Console.WriteLine(costs);

        }
    }
}
