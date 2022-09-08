using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            month = month.ToLower();
            int nights = int.Parse(Console.ReadLine());
            string hotelRoom = "";
            double studioPrice = 0;
            double studioMayOct = 50.00;
            double studioJuneSept = 75.20;
            double studioJulyAug = 76.00;
            double apartmentPrice = 0;
            double apartmentMayOct = 65.00;
            double apartmentJuneSept = 68.70;
            double apartmentJulyAug = 77.00;

            if (month == "may" || month == "october")
            {
                studioPrice = nights * studioMayOct;
                apartmentPrice = nights * apartmentMayOct;

                if (nights >= 7)
                {
                    studioPrice = studioPrice - studioPrice * 0.05;
                }
                else if (nights > 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.3;
                    apartmentPrice = apartmentPrice - apartmentPrice * 0.1;
                }
            }
            else if (month == "june" && month == "september")
            {
                studioPrice = nights * studioJuneSept;
                apartmentPrice = nights * apartmentJuneSept;
                if (nights > 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.2;
                    apartmentPrice = apartmentPrice - apartmentPrice * 0.1;
                }
            }
            else if (month == "july" && month == "august")
            {
                studioPrice = nights * studioJulyAug;
                apartmentPrice = nights * apartmentJulyAug;
                if (nights > 14)
                {
                    apartmentPrice = apartmentPrice - apartmentPrice * 0.1;
                }

            }



            Console.WriteLine($"Apartment: {apartmentPrice:f2}");
            Console.WriteLine($"Studio: {studioPrice:f2}");

        }
    }
}
