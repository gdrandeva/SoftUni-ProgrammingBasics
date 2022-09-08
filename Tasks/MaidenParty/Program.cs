using System;

namespace MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double maidenPartyPrice = double.Parse(Console.ReadLine());
            int loveLetterNumber = int.Parse(Console.ReadLine());
            int waxRosesNumber = int.Parse(Console.ReadLine());
            int keychainsNumber = int.Parse(Console.ReadLine());
            int caricaturesNumber = int.Parse(Console.ReadLine());
            int surprisesNumber = int.Parse(Console.ReadLine());

            double loveLetter = 0.60;
            double waxRose = 7.20;
            double keychain = 3.60;
            double caricature = 18.20;
            double surprise = 22.0;

            double priceOfAll = (loveLetter * loveLetterNumber) + (waxRose * waxRosesNumber) + (keychain * keychainsNumber) + (caricature * caricaturesNumber) + (surprise * surprisesNumber);
            double finalSum=0;
            int totalQuantity = loveLetterNumber + waxRosesNumber + keychainsNumber + caricaturesNumber + surprisesNumber;
           
            if (totalQuantity >= 25)
            {
                finalSum = priceOfAll - priceOfAll * 0.35;
            }
            else
            {
                finalSum = priceOfAll;
            }

            finalSum -= finalSum * 0.1;

            if (finalSum >= maidenPartyPrice)
            {
                Console.WriteLine($"Yes! {finalSum-maidenPartyPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {maidenPartyPrice-finalSum:f2} lv needed.");
            }
        }
    }
}
