using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {

            //•	Група до 5 човека – изкачват Мусала
            //•	Група от 6 до 12 човека – изкачват Монблан
            //•	Група от 13 до 25 човека – изкачват Килиманджаро
            //•	Група от 26 до 40 човека –  изкачват К2
            //•	Група от 41 или повече човека – изкачват Еверест
                
            int teamsNumber = int.Parse(Console.ReadLine());
            int membersInTeam = 0;
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;
           

            for (int i = 0; i < teamsNumber; i++)
            {
                membersInTeam = int.Parse(Console.ReadLine());

                if (membersInTeam <= 5) // Musala peak
                {
                    p1+=membersInTeam;
                    

                }
                else if (membersInTeam <= 12)
                {
                    p2+=membersInTeam;
                }
                else if (membersInTeam <= 25)
                {
                    p3+=membersInTeam;
                }
                else if (membersInTeam <= 40)
                {
                    p4+=membersInTeam;
                }
                else if (membersInTeam >= 41 )
                {
                    p5+=membersInTeam;
                }

            }
            double people = p1 + p2 + p3 + p4 + p5;
            p1 = p1  /people * 100;
            p2 = p2 /people * 100;
            p3 = p3  /people * 100;
            p4 = p4 / people *  100;
            p5 = p5  / people * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");


        }
    }
}
