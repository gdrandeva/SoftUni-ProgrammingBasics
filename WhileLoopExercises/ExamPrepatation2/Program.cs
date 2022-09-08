using System;

namespace ExamPrepatation2
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGradePoints = int.Parse(Console.ReadLine());
            string task = Console.ReadLine();
            double gradePoint = 0;
            double gradePointsSum = 0;
            double averageScore = 0.0;
            int sumTasks = 0;
            string lastTask = "";
            int poorGradePointsCounter = 0;

            while (task != "Enough")
            {
                lastTask = task;
                sumTasks++;
                gradePoint = double.Parse(Console.ReadLine());
                
                
                
                gradePointsSum += gradePoint;
                if (gradePoint <= 4)
                {
                    poorGradePointsCounter++;
                    if (poorGradePoints == poorGradePointsCounter)
                    {
                        Console.WriteLine($"You need a break, {poorGradePoints} poor grades.");
                        return;
                    }
                   
                }
                lastTask = task;
                task = Console.ReadLine();
                
            }
            averageScore = gradePointsSum / sumTasks;
            Console.WriteLine($"Average score: {averageScore:f2}");
            Console.WriteLine($"Number of problems: {sumTasks}");
            Console.WriteLine($"Last problem: {lastTask}");

            //while (true)
            //{

            //    if (task == "Enough")
            //    {
            //        Console.WriteLine($"Average score: {averageScore:f2}");
            //        Console.WriteLine($"Number of problems: {sumTasks}");
            //        Console.WriteLine($"Last problem: {lastTask}");
            //        break;
            //    }
            //    sumTasks++;
            //    gradePoint = int.Parse(Console.ReadLine());
            //    gradePointsSum += gradePoint;
            //    averageScore = gradePointsSum / sumTasks;
            //    if (gradePoint <= 4)
            //    {
            //        poorGradePointsCounter++;
            //        if (poorGradePointsCounter == poorGradePoints)
            //        {
            //            Console.WriteLine($"You need a break, {poorGradePoints} poor grades.");
            //            break;
            //        }
            //    }
            //    lastTask = task;
            //    task = Console.ReadLine();
            //}



        }
    }
}
