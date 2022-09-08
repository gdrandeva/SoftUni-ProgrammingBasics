using System;

namespace Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int input = int.Parse(Console.ReadLine());
            double rate=0.0;
            double possibleSales;
            double numberOfSales=0;
            double averageRate=0;
            double finalAverageRate = 0;
            int counter=0;

            for (int i = 1; i <= n; i++)
            {
                rate = input % 10;
                possibleSales = input / 10;
                
                    counter++;
               

                    if (rate == 2)
                    {
                        possibleSales = 0;

                    }
                    else if (rate == 3)
                    {
                        possibleSales = possibleSales * 50 / 100;
                    }
                    else if (rate == 4)
                    {
                        possibleSales = possibleSales * 70 / 100;
                    }
                    else if (rate == 5)
                    {
                        possibleSales = possibleSales * 85 / 100;
                    }
                    else if (rate == 6)
                    {
                        possibleSales = possibleSales * 100 / 100;
                    }
                
                numberOfSales += possibleSales;
                
                averageRate += rate;
                finalAverageRate = averageRate / counter;
                

                if (i==n)
                {
                    break;
                }

                input = int.Parse(Console.ReadLine());

            
            }
            Console.WriteLine($"{numberOfSales:f2}");
            Console.WriteLine($"{finalAverageRate:f2}");
            
        }
    }
}
