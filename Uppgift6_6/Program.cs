using System;
namespace Uppgift6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriva det text");
            string input = Console.ReadLine();
            Console.WriteLine("");
            text(input);
        }
        static void text(string text1)
        {

            string[] words = text1.Split(" ");
            for(int i = 0; i < words.Length; i++)
            {
                if (i%2==1)
                {

                    Console.Write(words[i].ToUpper());
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}