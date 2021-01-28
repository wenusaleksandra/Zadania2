using System;

namespace Tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            for (int i = input.Length; i > 0; i--)
            {
                Console.Write(input[i - 1] + " ");
            }
        }
    }
}
