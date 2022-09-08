using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine().ToLower(); // GERGANA > gergana
            string password = Console.ReadLine();
            int counter = 0;

            string passwordAttempt = Console.ReadLine();

            while (passwordAttempt != password)
            {
                
                counter++;
                if (counter ==2)
                {
                    Console.WriteLine("Locked account");
                    passwordAttempt = Console.ReadLine();
                }
                
            }
            
        }
    }
}
