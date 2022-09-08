using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {

            int stayInDays = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            
            string rate = Console.ReadLine();

            double roomForOnePersonPerNightPrice = 18.00;
            double apartPerNightPrice = 25.00;
            double presApartPerNightPrice = 35.00;

            string roomForOnePerson = string.Empty;
            string apartment = string.Empty;
            string presidentApartment = string.Empty;


            double totalPrice = 0;
            stayInDays = stayInDays - 1;

            switch (stayInDays)
            {
                case < 10:
                    if (roomType == "apartment")
                    {
                        totalPrice = stayInDays * apartPerNightPrice;
                        totalPrice = totalPrice - totalPrice * 0.3;
                    }
                    else if (roomType == "president apartment")
                    {
                        totalPrice = stayInDays * presApartPerNightPrice;
                        totalPrice = totalPrice - totalPrice * 0.1;
                    }
                    else
                    {
                        totalPrice = stayInDays * roomForOnePersonPerNightPrice;
                    }
                    break;
                case >= 10 and <= 15:
                    if (roomType == "apartment")
                    {
                        totalPrice = stayInDays * apartPerNightPrice;
                        totalPrice = totalPrice - totalPrice * 0.35;
                    }
                    else if (roomType == "president apartment")
                    {
                        totalPrice = stayInDays * presApartPerNightPrice;
                        totalPrice = totalPrice - totalPrice * 0.15;
                    }
                    else
                    {
                        totalPrice = stayInDays * roomForOnePersonPerNightPrice;
                    }
                    break;
                case > 15:
                    if (roomType == "apartment")
                    {
                        totalPrice = stayInDays * apartPerNightPrice;
                        totalPrice = totalPrice - totalPrice * 0.5;
                    }
                    else if (roomType == "president apartment")
                    {
                        totalPrice = stayInDays * presApartPerNightPrice;
                        totalPrice = totalPrice - totalPrice * 0.2;
                    }
                    else
                    {
                        totalPrice = stayInDays * roomForOnePersonPerNightPrice;
                    }
                    break;
            }


            switch (rate)
            {
                case "positive":
                    totalPrice = totalPrice + totalPrice * 0.25;
                    break;
                default:
                    if (rate != "positive")
                    {
                        totalPrice = totalPrice - totalPrice * 0.1;
                    }

                    break;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
