﻿using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int k = 1; k <= 9; k++)
            {
                for (int l = 1; l <= 9; l++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int i = 1; i <= 9; i++)
                        {
                            if (n%i==0 && n%j==00 && n%l==0 && n%k==00)
                            {
                                Console.WriteLine($"{k}{l}{j}{i} ");
                            }
                            
                        }
                    }
                }
            }
            
            
            
        }
    }
}
