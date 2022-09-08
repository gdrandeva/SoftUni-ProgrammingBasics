using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numMin = int.MaxValue;
            int numMax = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > numMax)
                {
                    numMax = num;
                }
               if (num < numMin)
                {
                    numMin = num;
                }
               
                
            }
            Console.WriteLine($"Max number: {numMax}");
            Console.WriteLine($"Min number: {numMin}");
            
        }
    }
}
