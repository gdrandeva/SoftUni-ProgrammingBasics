using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double yearlyGrade = 0;
            double averageGrade = 0;
            double sum = 0;
            int counter = 0;
            
            while (grade <= 12)
            {
                yearlyGrade = double.Parse(Console.ReadLine());
                if (yearlyGrade < 4)
                {
                    if (counter == 1)
                    {
                        break;
                    }
                    counter++;
                    continue;
                }
                sum += yearlyGrade;
                                grade++;
            }
            averageGrade = sum / 12;
            if (grade > 12) //or (counter <=1)
            {
                Console.WriteLine(averageGrade);
            }
            
        }
    }
}
