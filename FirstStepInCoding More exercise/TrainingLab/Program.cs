using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double wLenght = double.Parse(Console.ReadLine());
            double hWidth = double.Parse(Console.ReadLine());

            double wLenghtCm = wLenght * 100;
            double hWidthCm = hWidth * 100;

            double hWidthCmNoCorridor = hWidthCm - 100;




            // Едно работно място заема 70 на 120 cm(маса с размер 70 на 40 cm + място за стол и преминаване с размер 70 на 80 cm)
            double deskRow = hWidthCmNoCorridor / 70;

            //Console.WriteLine(Math.Truncate(deskRow));
          
            double deskColumn = wLenghtCm / 120;
            //Console.WriteLine(Math.Truncate(deskColumn));
            double seats = (deskRow * deskColumn) - 3;



            // print tje count of workplaces
            Console.WriteLine(seats);



        }
    }
}
