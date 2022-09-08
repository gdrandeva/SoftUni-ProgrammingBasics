using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = string.Empty;
            string shoes = string.Empty;

            //switch (time)
            //{
            //    ca
            
            outfit = "Sweatshirt";
            //            shoes = "Sneakers";
            //        }
            //        else if (degrees <= 24)
            //        {
            //            outfit = "Shirt";
            //            shoes = "Moccasins";
            //        }
            //        else
            //        {
            //            outfit = "T-Shirt";
            //            shoes = "Sandals";
            //        }
            //        break;
            //    case "Afternoon":
            //        if (degrees >= 10 && degrees <= 18)
            //        {
            //            outfit = "Shirt";
            //            shoes = "Moccasins";
            //        }
            //        else if (degrees <= 24)
            //        {
            //            outfit = "T-Shirt";
            //            shoes = "Sandals";
            //        }
            //        else
            //        {
            //            outfit = "Swim Suit";
            //            shoes = "Barefoot";
            //        }
            //        break;
            //    case "Evening":
            //        if (degrees >= 10 && degrees <= 18)
            //        {
            //            outfit = "Shirt";
            //            shoes = "Moccasins";
            //        }
            //        else if (degrees <= 24)
            //        {
            //            outfit = "Shirt";
            //            shoes = "Moccasins";
            //        }
            //        else
            //        {
            //            outfit = "Shirt";
            //            shoes = "Moccasins";
            //        }
            //        break;
            //}
            //Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

            if (time == "Morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            if (time == "Afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (time == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

        }
        
    }
}
