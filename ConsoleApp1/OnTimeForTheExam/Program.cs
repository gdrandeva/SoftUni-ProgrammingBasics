using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());

            int hourArrival = int.Parse(Console.ReadLine());
            int minuteArrival = int.Parse(Console.ReadLine());

            minuteExam = minuteExam + hourExam * 60;
            minuteArrival = minuteArrival + hourArrival * 60;
            
            int difference = minuteArrival - minuteExam;
            int diffHour = difference / 60;
            int diffMin = difference % 60;

            if (minuteExam < minuteArrival)
            {
                Console.WriteLine("Late");
                difference = minuteArrival - minuteExam;
                diffHour = difference / 60;
                diffMin = difference % 60;
                if (diffHour >= 1)
                {
                    if (diffMin < 10)
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diffHour}:{diffMin} hours after the start");
                    }
                                       
                }
                else
                {
                    Console.WriteLine($"{diffMin} minutes after the start");
                }
            }
            else if (minuteExam - minuteArrival <= 30)
            {
                Console.WriteLine("On time");
                difference = minuteExam - minuteArrival;
               
                if (minuteExam != minuteArrival)
                {  
            }
            else
            {
                Console.WriteLine("Early");
                difference = minuteExam - minuteArrival;
                diffHour = difference / 60;
                diffMin = difference % 60;
                if (diffHour >= 1)
                {
                    if (diffMin < 10)
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diffHour}:{diffMin} hours before the start");
                    }

                }
                else
                {
                    Console.WriteLine($"{diffMin} minutes before the start");
                }
            }
        }
        
    }
}
