using System;

namespace FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double scores = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = Console.ReadLine();
            double reward = 0.0;
            double costs = 0.0;
            double finalReward = 0.0;

            switch (destination)
            {
                case "Bulgaria":
                    reward = dancers * scores;
                    switch (season)
                    {
                        case "summer":
                            costs = reward * 0.05;
                            break;
                        case "winter":
                            costs = reward * 0.08;
                            break;
                    }
                    break;
                case "Abroad":
                    reward = dancers * scores;
                    reward += reward * 0.5;
                    switch (season)
                    {
                        case "summer":
                            costs = reward * 0.1;
                            break;
                        case "winter":
                            costs = reward * 0.15;
                            break;
                    }
                    break;
            }
            finalReward = reward - costs;
            double donation = finalReward * 0.75;
            double restMoney = finalReward - donation;
            double sumEachPerson = restMoney / dancers;

            Console.WriteLine($"Charity - {donation:f2}");
            Console.WriteLine($"Money per dancer - {sumEachPerson:f2}");
        }
    }
}
