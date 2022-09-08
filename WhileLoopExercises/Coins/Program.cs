using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double changeToReturn = double.Parse(Console.ReadLine());
            changeToReturn = changeToReturn * 100;
            int counter = 0;

            while (changeToReturn > 0)
            {
                if (changeToReturn >= 200)
                {
                    changeToReturn -= 200;
                    counter++;
                }
                else if (changeToReturn >=100)
                {
                    changeToReturn -= 100;
                    counter++;
                }
                else if (changeToReturn >=50)
                {
                    changeToReturn -= 50;
                    counter++;
                }
                else if (changeToReturn >= 20)
                {
                    changeToReturn -= 20;
                    counter++;
                }
                else if (changeToReturn >= 10)
                {
                    changeToReturn -= 10;
                    counter++;
                }
                else if (changeToReturn >= 5)
                {
                    changeToReturn -= 5;
                    counter++;
                }
                else if (changeToReturn >= 2)
                {
                    changeToReturn -= 2;
                    counter++;
                }
                else if (changeToReturn >= 1)
                {
                    changeToReturn -= 1;
                    counter++;
                }
                else
                {
                    changeToReturn = 0;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
