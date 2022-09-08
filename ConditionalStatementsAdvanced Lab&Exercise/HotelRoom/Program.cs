using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioMayOct = 50.00;
            double apartMayOct = 65.00;
            double studioJuneSept = 75.20;
            double apartJuneSept = 68.70;
            double studioJulyAug = 76.00;
            double apartJulyAug = 77.00;
            double studioMayOctDiscount7 = studioMayOct * 0.05;
            double studioMayOctDiscount14 = studioMayOct * 0.3;
            double studioJuneSeptDiscount14 = studioJuneSept * 0.2;
            double apartmentDiscount = 0.1;
            double studioPrice = 0.00;
            double apartPrice = 0.00;

            //switch (month)
            //{
            //    case "May":
            //    case "October":
            //        if (nights > 14)
            //        {
            //            studioPrice = studioMayOct * nights - studioMayOctDiscount14 * nights;
            //            apartPrice = apartMayOct * nights - apartmentDiscount * apartMayOct * nights;
            //        }
            //        else if (nights > 7 && nights < 14)
            //        {
            //            studioPrice = studioMayOct * nights - studioMayOctDiscount7 * nights;
            //            apartPrice = apartMayOct * nights;
            //        }
            //        break;
            //    case "June":
            //    case "September":
            //        if (nights > 14)
            //        {
            //            studioPrice = studioJuneSept * nights - studioJuneSeptDiscount14 * nights;
            //            apartPrice = apartJuneSept * nights - apartmentDiscount * apartJuneSept * nights;
            //        }
            //        else if (nights <= 14)
            //        {
            //            studioPrice = studioJuneSept * nights;
            //            apartPrice = apartJuneSept * nights;
            //        }
            //        break;
            //    default:
            //    case "July":
            //    case "August":
            //        if (nights > 14)
            //        {
            //            studioPrice = studioJulyAug * nights;
            //            apartPrice = apartJulyAug * nights - apartmentDiscount * apartJulyAug * nights;
            //        }
            //        break;
            //}

            if (nights > 14 && (month == "May" || month == "October"))
            {
                studioPrice = studioMayOct * nights - studioMayOctDiscount14 * nights;
                apartPrice = apartMayOct * nights - apartmentDiscount * apartMayOct * nights;
            }
            else if (nights < 14 && nights > 7 && (month == "May" || month == "October"))
            {
                studioPrice = studioMayOct * nights - studioMayOctDiscount7 * nights;
                apartPrice = apartMayOct * nights;
            }
            if (nights > 14 && (month == "June" || month == "September"))
            {
                studioPrice = studioJuneSept * nights - studioJuneSeptDiscount14 * nights;
                apartPrice = apartJuneSept * nights - apartmentDiscount * apartJuneSept * nights;
            }
            else if (nights <= 14)
            {
                studioPrice = studioJuneSept * nights;
                apartPrice = apartJuneSept * nights;
            }
            if (nights > 14 && (month == "July" || month == "August"))
            {
                studioPrice = studioJulyAug * nights;
                apartPrice = apartJulyAug * nights - apartmentDiscount * apartJulyAug * nights;
            }
            else if (nights <= 14)
            {
                studioPrice = studioJulyAug * nights;
                apartPrice = apartJulyAug * nights;
            }



                Console.WriteLine($"Apartment: {apartPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");



        }
    }
}
