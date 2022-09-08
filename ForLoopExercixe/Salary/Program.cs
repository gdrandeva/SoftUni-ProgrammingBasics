using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            string webSite = "";
            int penalty = 0;

            for (int i = 1; i <= openTabs; i++)
            {
                webSite = Console.ReadLine();
                if (webSite == "Facebook")
                {
                    penalty += 150;
                }
                else if (webSite == "Instagram")
                {
                    penalty += 100;
                }
                else if (webSite == "Reddit")
                {
                    penalty += 50;
                }
                if (penalty >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

                
            
             if(penalty<salary)
                {
                    Console.WriteLine(salary-penalty);
                }
            

            
        }
    }
}
