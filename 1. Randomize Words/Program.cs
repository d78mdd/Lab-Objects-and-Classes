using System;
using System.Linq;

namespace _1.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ')
                .ToArray();

            Random rnd = new Random();

            for (int i = 0; i < words.Length - 1; i++)
            {
                int n = rnd.Next(i, words.Length);

                string temp = words[i];
                words[i] = words[n];
                words[n] = temp;
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
