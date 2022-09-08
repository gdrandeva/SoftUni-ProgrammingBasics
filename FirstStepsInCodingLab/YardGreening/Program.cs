using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            //define price per m2

            double priceM = 7.61;

            //calculate 18% discount



            //read the X m2 which will be greening

            double greenM = double.Parse(Console.ReadLine());
            double price = priceM * greenM;
            double discount = price * 0.18;
            double finalPrice = price - discount;

            //print  •	"The final price is: {крайна цена на услугата} lv." and •	"The discount is: {отстъпка} lv."

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");


        }
    }
}
