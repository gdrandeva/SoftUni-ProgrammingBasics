using System;

namespace GeneralWl
{
    class Program
    {
        static void Main(string[] args)
        {
            //string areThereAnyDishes = Console.ReadLine();
            //while (areThereAnyDishes == "yes")
            //{
            //    Console.WriteLine("Washing a dish");
            //    areThereAnyDishes = Console.ReadLine();
            //}

            //int numberOfDishes = 10;

            //while (numberOfDishes > 0)
            //{
            //    Console.WriteLine("Washing a dish");
            //    numberOfDishes--;
            //}


            //string input = Console.ReadLine();

            //while (input != "Stop")
            //{
            //    Console.WriteLine("Invalid input");
            //    input = Console.ReadLine();
            //}

            string command = Console.ReadLine();
            int sum = 0;

            while (command != "Stop")
            {
                sum += int.Parse(command);
                command = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
