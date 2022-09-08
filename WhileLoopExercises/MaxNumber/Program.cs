using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //string num = "";
            //int maxNum = int.MinValue;


            //while (true)
            //{    
            //    num = Console.ReadLine();
            //    if (num == "Stop")
            //    {
            //        break;
            //    }
            //    int convNum = int.Parse(num);
            //    if (convNum > maxNum)
            //    {
            //        maxNum = convNum;
            //    }
            //}

            //Console.WriteLine(maxNum);

            //string number = "".ToLower();
            //int convertedNumber = 0;
            //int maxNum = int.MinValue;

            //while (number!="stop")
            //{
            //    number = Console.ReadLine().ToLower();
            //    if (number == "stop")
            //    {
            //        break;
            //    }
            //    convertedNumber = int.Parse(number);
            //    if (convertedNumber>maxNum)
            //    {
            //        maxNum = convertedNumber;
            //    }
            //    else if (number == "stop")
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(maxNum);

            string number = Console.ReadLine();
            int maxNum = int.MinValue;
            int readNumber = 0;

            while (number!="Stop")
            {
                readNumber = int.Parse(number);
                if (readNumber>maxNum)
                {
                    maxNum = readNumber;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine(maxNum);

        }
    }
}
