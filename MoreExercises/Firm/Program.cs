using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());

            //            Фирма получава заявка за изработването на проект, за който са необходими определен брой часове.Фирмата разполага с определен брой дни. През 10 % от дните служителите са на обучение и не могат да работят по проекта. Един нормален работен ден във фирмата е 8 часа.Всеки служител може да работи по проекта в извънработно време по 2 часа на ден.
            //Часовете трябва да са закръглени към по - ниско цяло число(Например –> 6.98 часа се закръглят на 6 часа).
            //Напишете програма, която изчислява дали фирмата може да завърши проекта навреме и колко часа не достигат или остават.


           
            int daysInHours = days * 8;
            double trainingHours = daysInHours * 0.1;
            double remainingHours = daysInHours - trainingHours;
            //double workingDays = remainingHours / 10;
            double overtime = numberOfPeople * 2 * daysInHours/8;
            double workingHours = remainingHours + overtime;

            if (workingHours >= neededHours)
            {
                Console.WriteLine($"Yes!{Math.Floor(workingHours-neededHours)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Floor(neededHours-workingHours)} hours needed.");
            }
        }
    }
}
