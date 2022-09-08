using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string input = Console.ReadLine(); ;
            double gradePoint;
            
            int presentationNum=0;
            double sumPoints=0;
            double sumPointsOfAll=0;
            double averagePoint;
            double averagePointOfAll=0;

            while (input != "Finish")
            {
                sumPoints = 0;
                for (int i = 1; i <= jury; i++)
                {
                    gradePoint = double.Parse(Console.ReadLine());
                    sumPoints += gradePoint;
                }
                presentationNum++;
                averagePoint = sumPoints / jury;
                Console.WriteLine($"{input} - {averagePoint:f2}.");
               
                sumPointsOfAll += averagePoint;
                averagePointOfAll = sumPointsOfAll / presentationNum;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {averagePointOfAll:f2}.");
            
        }
    }
}
