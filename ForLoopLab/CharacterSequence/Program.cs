using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            //int namee = name.Length;

            for (int i = 0; i < name.Length; i++)//cat
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
