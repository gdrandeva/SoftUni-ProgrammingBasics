using System;

namespace While_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string newBook = Console.ReadLine();
            int count = 0;

            while (newBook != "No More Books")
            {
                if (newBook == favoriteBook)
                {
                    break;
                }                
                count++;
                newBook = Console.ReadLine();
            }

            if (newBook == favoriteBook)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }

            
            



        }
    }
}
