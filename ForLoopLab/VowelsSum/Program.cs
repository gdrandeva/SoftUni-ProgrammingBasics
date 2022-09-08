using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //  буква      a  e   i   o   u
            //стойност    1   2   3   4   5

            string name = Console.ReadLine();
            int sum = 0;
           



            for (int i = 0; i < name.Length; i++)
            {
                char vowel = name[i];
                switch (vowel)
                {
                    
                    case 'a':
                        sum = sum + 1;
                        break;
                    case 'e':
                        sum = sum + 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }
            Console.WriteLine(sum);
            

        }
    }
}
