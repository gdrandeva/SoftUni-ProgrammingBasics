using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTourney = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            string stage = "";
            double score = 0;
            double winnerPercent = 0.0;
            int counter = 0;

            for (int i = 0; i < numberOfTourney; i++)
            {

                
                stage = Console.ReadLine();

                switch (stage)
                {
                    case "W":
                        score += 2000;
                        counter++;

                        break;
                    case "F":
                        score += 1200;
                        break;
                    case "SF":
                        score += 720;
                        break;
                    default:
                        break;
                }
               
            }
            


            int avgScore = (int)score / numberOfTourney;
            score = initialPoints + score;
            //winnerPercent = double.Parse(counter.ToString()) / double.Parse(numberOfTourney.ToString()) * 100; 

                      

            Console.WriteLine($"Final points: {score}");
            Console.WriteLine($"Average points: {Math.Floor(avgScore)}");
            Console.WriteLine($"{winnerPercent:f2}%");



        }
    }
}
