using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            double gradePointAverage = 0.0;
            int gradeCounter = 0;
            int poorCounter = 0;
            double sumGPA = 0.0;

            while (true)
            {
                double annualGPA = double.Parse(Console.ReadLine());
                sumGPA += annualGPA;
                if (annualGPA >= 4)
                {
                    gradeCounter++;
                    if (gradeCounter >= 12)
                    {
                        break;
                    }
                }
                else
                {
                    poorCounter++;
                    if (poorCounter > 1)
                    {
                        gradeCounter++;
                        Console.WriteLine($"{name} has been excluded at {gradeCounter} grade");
                        return;
                    }
                }
            }
            gradePointAverage = sumGPA / gradeCounter;
            Console.WriteLine($"{name} graduated. Average grade: {gradePointAverage:f2}");
        }
    }
}
