using System;

namespace Cinema2
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double income = 0;

            if (type == "Premiere")
            {
                income = row * column * 12.00;
            }
            else if (type == "Normal")
            {
                income = row * column * 7.50;
            }
            else
            {
                income = row * column * 5.00;   
            }

            Console.WriteLine("{0:f2} leva", income);


        }
    }
}
