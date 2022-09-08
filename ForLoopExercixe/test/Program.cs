using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (true)
            {
                if (num > 10)
                {
                    break;
                }
                Console.WriteLine(num++);
            }
        }
    }
}
