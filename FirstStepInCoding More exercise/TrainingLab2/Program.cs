using System;

namespace TrainingLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // enter width and length
            double lengthMeters = double.Parse(Console.ReadLine());
            double widhtMeters = double.Parse(Console.ReadLine());

            // initilization other things

            int corridorWidthCm = 100;
            int workplaceWidthCm = 70;
            int workplaceLengthCm = 120;
            
            


            // convert to cm

            double hallLength = lengthMeters * 100;
            double hallWidth = widhtMeters * 100;

            //calculate a number of rows and a number of columns

            double rowNumber = (hallWidth - corridorWidthCm) / workplaceWidthCm;
            double rows = (Math.Truncate(rowNumber));
           
            double columnNumber = (hallLength / workplaceLengthCm);
            double columns = (Math.Truncate(columnNumber)); // previous try was with Math.Round and it worked


            // calculate the quantity of workplaces
            double totalWorkplaces = (rows * columns) -3;

            Console.WriteLine(totalWorkplaces);
        }
    }
}
