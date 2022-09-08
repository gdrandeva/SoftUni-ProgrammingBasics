using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            double pencilPrice = 5.80;
            double markerPrice = 7.20;
            double prepPerLiter = 1.20;


            // read pencils count

            int pencilsCount = int.Parse(Console.ReadLine());
            int markersCount = int.Parse(Console.ReadLine());
            int prepLiter = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            // read markers count

            // read preparation quantity

            //percent discount



            // print final cost for the supplies

            double price = (pencilPrice * pencilsCount) + (markerPrice * markersCount) + (prepPerLiter * prepLiter);
            double discount = percent * price / 100;
            double finalPrice = price - discount;

            Console.WriteLine(finalPrice);
        }
    }
}
