using System;

namespace Password2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string yourPass = Console.ReadLine();

            while (yourPass != password)
            {

                yourPass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {yourPass}!");
        }
    }
}
