using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGradeCount = int.Parse(Console.ReadLine());
            string nameTask = Console.ReadLine();
            int points = int.Parse(Console.ReadLine());
            double averagePoints = 0;
            int counter = 0;
            int counterBad = 0;
            double pointsSum = 0.0;
            string lastTask = string.Empty;

            while (nameTask != "Enough")
            {
                lastTask = nameTask;
                counter++;
                nameTask = Console.ReadLine();
                points = int.Parse(Console.ReadLine());
                pointsSum += points;
                if (points <=4)
                {
                    counterBad++;
                    if (counterBad == badGradeCount)
                    {
                        Console.WriteLine($"You need a break, {badGradeCount} poor grades."); 
                        break;
                    }
                    if (counterBad != badGradeCount)
                    {
                        Console.WriteLine($"Average score: {averagePoints}");
                        Console.WriteLine($"Number of problems: {pointsSum / counter:f2}");
                        Console.WriteLine($"Last problem: {lastTask}");
                    }

                }
            }
           
            
        }
    }
}
