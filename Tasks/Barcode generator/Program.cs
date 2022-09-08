using System;

namespace Barcode_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int d1 = start/1000; d1 <= end/1000; d1++)
            {
                if (d1 % 2 == 0)
                {
                    continue;
                }
                for (int d2 = start/100%10; d2 <= end/100%10; d2++)
                {
                    if (d2 % 2 == 0)
                    {
                        continue;
                    }
                    for (int d3 = start /10%10; d3 <= end/10%10; d3++)
                    {
                        if (d3 % 2 == 0)
                        {
                            continue;
                        }
                        for (int d4 = start%10; d4 <= end%10; d4++)
                        {
                            if (d4 % 2 == 0)
                            {
                                continue;
                            }
                            Console.Write($"{d1}{d2}{d3}{d4} ");
                        }
                    }
                }
            }
        }
    }
}

