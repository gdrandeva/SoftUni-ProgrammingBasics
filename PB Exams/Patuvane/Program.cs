using System;

namespace Patuvane
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string destination = Console.ReadLine();
            int minBudget;
            int savedMoney;
           

            while (destination != "End")
            {
                minBudget = int.Parse(Console.ReadLine());
               

                for (int sum = 0; sum <= minBudget; sum+=savedMoney)
                {
                    savedMoney = int.Parse(Console.ReadLine());
                   
                }
               
               
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();

            }   


        }
    }
}
