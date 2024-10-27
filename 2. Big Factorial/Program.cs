using System;
using System.Numerics;

namespace _2.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 2; i <= N; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
