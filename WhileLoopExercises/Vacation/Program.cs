using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            string action = "";
            double money = 0.0;
            int daysCounter = 0;
            int spendCounter = 0;

            while (availableMoney < moneyForVacation)
            {
                action = Console.ReadLine(); // spend or 
                money = double.Parse(Console.ReadLine());
                daysCounter++;

                if (action == "save")
                {
                    availableMoney += money;
                    spendCounter = 0;
                }
                else
                {
                    availableMoney -= money;
                    spendCounter++;

                    if (availableMoney<0)
                    {
                        availableMoney = 0;
                    }
                }
                if (spendCounter >=5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysCounter}");
                    break;
                }
            }
            if (availableMoney>=moneyForVacation)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
