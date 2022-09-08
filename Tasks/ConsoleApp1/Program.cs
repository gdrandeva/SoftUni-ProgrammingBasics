using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int d = 9; d >= c; d--)
            {
                for (int c = 0; c <= 9; c++)
                    
                {
                    for (int b = 9; b >= a; b--)
                    {
                        
                            for (int a = 1; a <= 9; a++)
                            {
                           
                            
                            
                            if ((a + b + c + d == a * b * c * d) && n % 10 == 5)
                            {
                                Console.WriteLine($"{a}{b}{c}{d}");


                            }
                            else if ((a * b * c * d) / (a + b + c + d) == 3)
                            {
                                Console.WriteLine($"{d}{c}{b}{a}");

                            }


                        }

                    }

                }

            }

            Console.WriteLine("Nothing found.");
        }
    }
}
