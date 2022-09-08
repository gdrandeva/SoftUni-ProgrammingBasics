using System;

namespace ForGeneral
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;

            //a++;
            //a--;
            //--a;
            //int i = 1;
            //for (; i <= 10; )
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i+=2)
            //{

            //    Console.WriteLine(i);
            //}
            //
            //int n = int.Parse(Console.ReadLine());

            //for (int power = 0; power <= n; power++)
            //{
            //    if (power % 2 ==0)
            //    {
            //        Console.WriteLine(Math.Pow(2, power));
            //    }

            //}

            //for (int power = 0; power <= n; power += 2)
            //{
            //    Console.WriteLine(Math.Pow(2, power));
            //}

            //string text = Console.ReadLine();

            //Console.WriteLine(text[text.Length - 1]) ;

            //Console.WriteLine(text.Length); //7

            //Console.WriteLine(text[0]);
            //Console.WriteLine(text[1]);
            //Console.WriteLine(text[2]);
            //Console.WriteLine(text[3]);
            //Console.WriteLine(text[4]);
            //Console.WriteLine(text[5]);
            //Console.WriteLine(text[6]);

            //for (int i = 0; i < text.Length; i++)
            //{
            //    Console.WriteLine(text[i]);
            //}

            //string text = Console.ReadLine();
            //int sum = 0;

            //for (int i = 0; i < text.Length ; i++)
            //{
            //    char currentsymbol = text[i];

            //    switch (currentsymbol)
            //    {
            //        case 'a':
            //            sum++;
            //            break;
            //        case 'e':
            //            sum += 2;
            //            break;
            //        case 'i':
            //            sum += 3;
            //            break;
            //        case 'o':
            //            sum += 4;
            //            break;
            //        case 'u':
            //            sum += 5;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine(sum);

            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    sum += num;
            //}
            //Console.WriteLine(sum);

            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
