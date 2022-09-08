using System;

namespace PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double x1 = double.Parse(Console.ReadLine());//2
            double y1= double.Parse(Console.ReadLine());//6
            double x2 = double.Parse(Console.ReadLine());//4
            double y2= double.Parse(Console.ReadLine());//8
            double x = double.Parse(Console.ReadLine());//2
            double y = double.Parse(Console.ReadLine());//7

            bool firstCondition = ((x == x1 || x == x2) && (y >= y1 && y <= y2));
            bool secondCondition = ((y == y1 || y == y2) && (x >= x1 && x <= x2));

            if (firstCondition || secondCondition)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
             
        }
    }
}
