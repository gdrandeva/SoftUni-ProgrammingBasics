using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {

            //Architect`s name

            string archName = Console.ReadLine();

            //count of projecst

            int projectsCount = int.Parse(Console.ReadLine());

            //calculate the needed time

            int time = projectsCount * 3;

            //"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."

            Console.WriteLine($"The architect {archName} will need {time} hours to complete {projectsCount} project/s.");
        }
    }
}
