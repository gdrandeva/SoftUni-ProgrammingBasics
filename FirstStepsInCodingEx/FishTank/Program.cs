using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // read : lenght, width, height, percent

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            // calculate the volume of the fish tank

            int volumeCm3 = length * width * height;
            double volumeInLiters = volumeCm3 / 1000;
            double accessories = percent * volumeInLiters;
            double water = volumeInLiters * 83;

            Console.WriteLine(water);


            // 
        }
    }
}
