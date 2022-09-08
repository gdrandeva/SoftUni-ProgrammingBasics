using System;

namespace NewHouse2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            цвете Роза    Далия Лале    Нарцис Гладиола
            //Цена на брой в лева 5   3.80    2.80    3   2.50

          
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
            //От конзолата се четат 3 реда:
            //•	Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            

            string flowerType = Console.ReadLine();
            int flowerQuantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double rosesPrice = flowerQuantity * 5.00;
            double dahliasPrice = flowerQuantity * 3.80;
            double tulipsPrice = flowerQuantity * 2.80;
            double narcissusPrice = flowerQuantity * 3.00;
            double gladiolusPrice = flowerQuantity * 2.50;

            double rosesDiscount = rosesPrice * 0.10;
            double dahliasDiscount = dahliasPrice * 0.15;
            double tulipsDiscount = tulipsPrice * 0.15;
            double narcissusOvercharge = narcissusPrice * 0.15;
            double gladiolusOvercharge = gladiolusPrice * 0.20;

            switch (flowerType)
            {
                case "Roses":
                    if (flowerQuantity > 80)
                    {
                        rosesPrice = rosesPrice - rosesDiscount;
                    }
                    if (budget > rosesPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flowerType} and {budget - rosesPrice:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {rosesPrice - budget:f2} leva more.");
                    }
                    break;
                case "Dahlias":
                    if (flowerQuantity > 90)
                    {
                        dahliasPrice = dahliasPrice - dahliasDiscount;
                    }
                    if (budget > dahliasPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flowerType} and {budget - dahliasPrice:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {dahliasPrice - budget:f2} leva more.");
                    }
                    break;
                case "Tulips":
                    if (flowerQuantity > 80)
                    {
                        tulipsPrice = tulipsPrice - tulipsDiscount;
                    }
                    if (budget > tulipsPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flowerType} and {budget - tulipsPrice:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {tulipsPrice - budget:f2} leva more.");
                    }
                    break;
                case "Narcissus":
                    if (flowerQuantity < 120)
                    {
                        narcissusPrice = narcissusPrice + narcissusOvercharge;
                    }
                    if (budget > narcissusPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flowerType} and {budget - narcissusPrice:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {narcissusPrice - budget:f2} leva more.");
                    }
                    break;
                case "Gladiolus":
                    if (flowerQuantity < 80)
                    {
                        gladiolusPrice = gladiolusPrice + gladiolusOvercharge;
                    }
                    if (budget > gladiolusPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flowerType} and {budget - gladiolusPrice:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {gladiolusPrice - budget:f2} leva more.");
                    }
                    break;

            }
        }
    }
}
