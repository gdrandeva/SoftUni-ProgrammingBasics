using System;

namespace Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int joineryCount = int.Parse(Console.ReadLine());
            string typeJoinery = Console.ReadLine();//"90X130" или "100X150" или "130X180" или "200X300";
            string deliveryMethod = Console.ReadLine().ToLower();//"With delivery"  or - "Without delivery"
            int deliveryCost = 60;
            double joineryPrice = 0;
            int j90x130 = 110;
            int j100x150 = 140;
            int j130x180 = 190;
            int j200x300 = 250;

            if (joineryCount < 10)
            {
                Console.WriteLine("Invalid order");
            }
            if (joineryCount > 10)
            {
                if (deliveryMethod == "With delivery")

                    if (typeJoinery == "90x130")
                    {
                        if (joineryCount > 99)
                        {
                            joineryPrice = joineryCount * j90x130 - joineryCount * j90x130 * 0.08 + deliveryCost;
                            joineryPrice -= joineryPrice * 0.04;
                        }
                        else if (joineryCount > 60)
                        {
                            joineryPrice = joineryCount * j90x130 - joineryCount * j90x130 * 0.08 + deliveryCost;
                        }

                        else if (joineryCount > 30)
                        {
                            joineryPrice = joineryCount * j90x130 - joineryCount * j90x130 * 0.05 + deliveryCost;
                        }
                        else if (joineryCount < 30)
                        {
                            joineryPrice = joineryCount * j90x130 + deliveryCost;
                        }
                    }
                    else if (typeJoinery == "100x150")
                    {
                        if (joineryCount > 99)
                        {
                            joineryPrice = joineryCount * j100x150 - joineryCount * j100x150 * 0.1 + deliveryCost;
                            joineryPrice -= joineryPrice * 0.04;
                        }
                        else if (joineryCount > 80)
                        {
                            joineryPrice = joineryCount * j100x150 - joineryCount * j100x150 * 0.1 + deliveryCost;
                        }

                        else if (joineryCount > 40)
                        {
                            joineryPrice = joineryCount * j100x150 - joineryCount * j100x150 * 0.06 + deliveryCost;
                        }
                        else if (joineryCount < 40)
                        {
                            joineryPrice = joineryCount * j100x150 + deliveryCost;
                        }
                    }
                    else if (typeJoinery == "130x180")
                    {
                        if (joineryCount > 99)
                        {
                            joineryPrice = joineryCount * j130x180 - joineryCount * j130x180 * 0.12 + deliveryCost;
                            joineryPrice -= joineryPrice * 0.04;
                        }
                        else if (joineryCount > 50)
                        {
                            joineryPrice = joineryCount * j130x180 - joineryCount * j130x180 * 0.12 + deliveryCost;
                        }

                        else if (joineryCount > 20)
                        {
                            joineryPrice = joineryCount * j130x180 - joineryCount * j130x180 * 0.07 + deliveryCost;
                        }
                        else if (joineryCount < 20)
                        {
                            joineryPrice = joineryCount * j130x180 + deliveryCost;
                        }
                    }
                    else if (typeJoinery == "200x300")
                    {
                        if (joineryCount > 99)
                        {
                            joineryPrice = joineryCount * j200x300 - joineryCount * j200x300 * 0.14 + deliveryCost;
                            joineryPrice -= joineryPrice * 0.04;
                        }
                        else if (joineryCount > 50)
                        {
                            joineryPrice = joineryCount * j200x300 - joineryCount * j200x300 * 0.14 + deliveryCost;
                        }

                        else if (joineryCount > 25)
                        {
                            joineryPrice = joineryCount * j200x300 - joineryCount * j200x300 * 0.09 + deliveryCost;
                        }
                        else if (joineryCount < 25)
                        {
                            joineryPrice = joineryCount * j200x300 + deliveryCost;
                        }
                    }

                if (deliveryMethod == "Without delivery")
                    if (typeJoinery == "90x130")
                    {
                        if (joineryCount > 99)
                        {
                            joineryPrice = joineryCount * j90x130 - joineryCount * j90x130 * 0.08;
                            joineryPrice -= joineryPrice * 0.04;
                        }
                        else if (joineryCount > 60)
                        {
                            joineryPrice = joineryCount * j90x130 - joineryCount * j90x130 * 0.08;
                        }

                        else if (joineryCount > 30)
                        {
                            joineryPrice = joineryCount * j90x130 - joineryCount * j90x130 * 0.05;
                        }
                        else if (joineryCount < 30)
                        {
                            joineryPrice = joineryCount * j90x130;
                        }
                    }
                    else if (typeJoinery == "100x150")
                    {
                        if (joineryCount > 99)
                        {
                            joineryPrice = joineryCount * j100x150 - joineryCount * j100x150 * 0.1;
                            joineryPrice -= joineryPrice * 0.04;
                        }
                        else if (joineryCount > 80)
                        {
                            joineryPrice = joineryCount * j100x150 - joineryCount * j100x150 * 0.1;
                        }

                        else if (joineryCount > 40)
                        {
                            joineryPrice = joineryCount * j100x150 - joineryCount * j100x150 * 0.06;
                        }
                        else if (joineryCount < 40)
                        {
                            joineryPrice = joineryCount * j100x150;
                        }
                    }
                    else if (typeJoinery == "130x180")
                    {
                        if (joineryCount > 99)
                        {
                            joineryPrice = joineryCount * j130x180 - joineryCount * j130x180 * 0.12;
                            joineryPrice -= joineryPrice * 0.04;
                        }
                        else if (joineryCount > 50)
                        {
                            joineryPrice = joineryCount * j130x180 - joineryCount * j130x180 * 0.12;
                        }

                        else if (joineryCount > 20)
                        {
                            joineryPrice = joineryCount * j130x180 - joineryCount * j130x180 * 0.07;
                        }
                        else if (joineryCount < 20)
                        {
                            joineryPrice = joineryCount * j130x180;
                        }
                    }
                    else if (typeJoinery == "200x300")
                    {
                        if (joineryCount > 99)
                        {
                            joineryPrice = joineryCount * j200x300 - joineryCount * j200x300 * 0.14;
                            joineryPrice -= joineryPrice * 0.04;
                        }
                        else if (joineryCount > 50)
                        {
                            joineryPrice = joineryCount * j200x300 - joineryCount * j200x300 * 0.14;
                        }

                        else if (joineryCount > 25)
                        {
                            joineryPrice = joineryCount * j200x300 - joineryCount * j200x300 * 0.09;
                        }
                        else if (joineryCount < 25)
                        {
                            joineryPrice = joineryCount * j200x300;
                        }
                    }
                        Console.WriteLine($"{joineryPrice:f2} BGN");
            }
        }
    }
}
    
