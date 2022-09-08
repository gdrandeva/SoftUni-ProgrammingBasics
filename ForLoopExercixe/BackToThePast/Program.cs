using System;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int ivanAge = 17;
            
            for (int i = 1800; i <= year; i++)
            {
                ivanAge++;
                if (i%2==0)
                {
                    heritage = heritage - 12000;                    
                }
                else if (i%2!=0)
                {                    
                    heritage = heritage - (12000 + 50 * ivanAge);
                }                
            }
            if (heritage >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritage:f2} dollars left.");
            }
            else if (heritage < 0)
            {
                Console.WriteLine($"He will need {Math.Abs(heritage):f2} dollars to survive.");
            }

        }
    }
}
