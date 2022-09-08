using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string timePeriod = Console.ReadLine();
            string taxi = string.Empty;
            string bus = string.Empty;
            string train = string.Empty;
            double price = 0.0;
            double taxiRate = 0.0;
            double initialPrice = 0.70;


            //            Студент трябва да пропътува n километра. Той има избор измежду три вида транспорт:
            //•	Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
            //•	Автобус.Дневна / нощна тарифа: 0.09 лв. / км. Може да се използва за разстояния минимум 20 км.
            //•	Влак.Дневна / нощна тарифа: 0.06 лв. / км. Може да се използва за разстояния минимум 100 км.

            if (timePeriod == "day")
            {
                taxiRate = 0.79;
            }
            else
            {
                taxiRate = 0.90;
            }
            if (kilometers < 20)
            {
                price = initialPrice + kilometers * taxiRate;
            }
            else if (kilometers < 100)
            {
                price = kilometers * 0.09;
            }
            else
            {
                price = kilometers * 0.06;
            }

            Console.WriteLine($"{price:f2}");

        }
    }
}
