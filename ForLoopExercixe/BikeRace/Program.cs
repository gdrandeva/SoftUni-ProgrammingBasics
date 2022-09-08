using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Група trail   cross - country   downhill road
            //juniors 5.50    8   12.25   20
            // seniors 7   9.50    13.75   21.50

            int juniorNum = int.Parse(Console.ReadLine());
            int seniorNum = int.Parse(Console.ReadLine());
            string routeType = Console.ReadLine();
            double sum = 0.0;
            double juniorTrail = 5.50;
            double seniorTrail = 7.0;
            double juniorCrossCountry = 8.0;
            double seniorCrossCountry = 9.5;
            double juniorDownhill = 12.25;
            double seniorDownhill = 13.75;
            double juniorRoad = 20.0;
            double seniorRoad = 21.50;
            double donation = 0.0;


            switch (routeType)
            {
                case "trail":
                    sum = juniorNum * juniorTrail + seniorNum * seniorTrail;
                    break;
                case "cross-country":
                    sum = juniorNum * juniorCrossCountry + seniorNum * seniorCrossCountry;
                    if (juniorNum + seniorNum >= 50)
                    {
                        sum = sum - sum * 0.25;
                    }
                    break;
                case "downhill":
                    sum = juniorDownhill * juniorNum + seniorDownhill * seniorNum;
                    break;
                case "road":
                    sum = juniorNum * juniorRoad + seniorNum * seniorRoad;
                    break;
            }

            donation = sum - sum * 0.05;




            Console.WriteLine($"{donation:f2}");


        }
    }
}
