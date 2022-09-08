using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int time = first + second + third; //seconds

            int min = time / 60;
            int sec= time % 60;


            //if sec < 10 , we should print Console.WriteLine($"{min} : 0{sec}");

            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}"); ;
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }


        }
    }
}
