using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "";
            int convertedNumber = 0;
            int minNumber = int.MaxValue;

            while (true)
            {
                number = Console.ReadLine();
                if (number == "Stop")
                {
                    break;
                }
                convertedNumber = int.Parse(number);
                if (convertedNumber<minNumber)
                {
                    minNumber = convertedNumber;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
