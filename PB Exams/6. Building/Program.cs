using System;

namespace _6._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int roomType = int.Parse(Console.ReadLine());
            int counter = 0;
            bool flag = false;

            for (int i = floors; i > 0; i--)
            {
                for (int j = 0; j < roomType; j++)
                {
                    if (i==floors)
                    {
                        Console.Write($"L{i}{j} ");
                        counter++;
                        continue;
                    }
                    if (i%2==0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else if (i%2!=0)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                   
                }
                Console.WriteLine();
            }

           
        }
    }
}
