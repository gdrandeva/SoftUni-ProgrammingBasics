using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int numberPeople = int.Parse(Console.ReadLine());
            double assesorsPoints = 0;
            string assesorsName = "";

            for (int i = 1; i <= numberPeople; i++)
            {
                assesorsName = Console.ReadLine();
                assesorsPoints = double.Parse(Console.ReadLine());

                pointsAcademy += assesorsName.Length * assesorsPoints / 2;

                if (pointsAcademy >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsAcademy:f1}!");
                    break;
                }
            }
            if (pointsAcademy < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5-pointsAcademy:f1} more!");
            }

        }
    }
}
