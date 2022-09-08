using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType = Console.ReadLine();
            string groupSchoolmates = Console.ReadLine();
            int student = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0.0;
            double nightPrice = 0.0;
            double nightPriceBorGwinter = 9.60;
            double nightPriceBorGspring = 7.20;
            double nightPriceBorGsummer = 15.0;
            double nightPriceMixWinter = 10.0;
            double nightPriceMixSpring = 9.50;
            double nightPriceMixSummer = 20.0;            
            string sport = "";

            switch (vacationType)
            {
                case "Winter":
                    if (groupSchoolmates == "boys" || groupSchoolmates == "girls")
                    {
                        nightPrice = nightPriceBorGwinter;
                    }
                    else if (groupSchoolmates == "mixed")
                    {
                        nightPrice = nightPriceMixWinter;
                    }
                    if (groupSchoolmates == "boys" || groupSchoolmates == "girls")
                    {
                        nightPrice = nightPriceBorGwinter;
                    }
                    else if (groupSchoolmates == "mixed")
                    {
                        nightPrice = nightPriceMixWinter;
                    }
                    if (groupSchoolmates == "boys")
                    {
                        sport = "Judo";
                    }
                    else if (groupSchoolmates == "girls")
                    {
                        sport = "Gymnastics";
                    }
                    else if (groupSchoolmates == "mixed")
                    {
                        sport = "Ski";
                    }
                    break;
                case "Spring":
                    if (groupSchoolmates == "boys" || groupSchoolmates == "girls")
                    {
                        nightPrice = nightPriceBorGspring;
                    }
                    else if (groupSchoolmates == "mixed")
                    {
                        nightPrice = nightPriceMixSpring;
                    }

                    if (groupSchoolmates == "boys")
                    {
                        sport = "Tennis";
                    }
                    else if (groupSchoolmates == "girls")
                    {
                        sport = "Athletics";
                    }
                    else if (groupSchoolmates == "mixed")
                    {
                        sport = "Cycling";
                    }
                    break;
                case "Summer":
                    if (groupSchoolmates == "boys" || groupSchoolmates == "girls")
                    {
                        nightPrice = nightPriceBorGsummer;
                    }
                    else if (groupSchoolmates == "mixed")
                    {
                        nightPrice = nightPriceMixSummer;
                    }

                    if (groupSchoolmates == "boys")
                    {
                        sport = "Football";
                    }
                    else if (groupSchoolmates == "girls")
                    {
                        sport = "Volleyball";
                    }
                    else if (groupSchoolmates == "mixed")
                    {
                        sport = "Swimming";
                    }
                    break;
                default:
                    break;
            }
            price = nightPrice * nights * student;
            switch (vacationType)
            {
                case "Winter":
                case "Spring":
                case "Summer":
                    if (student >= 50)
                    {
                        price = price - price * 0.5;
                    }
                    else if (student >= 20)
                    {
                        price = price - price * 0.15;
                    }
                    else if (student >= 10)
                    {
                        price = price - price * 0.05;
                    }
                    else
                    {
                        price = price;
                    }
                    break;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
