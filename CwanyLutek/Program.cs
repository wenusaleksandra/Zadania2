using System;
using System.Numerics;

namespace Dodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaTestow; i++)
            {
                string input = Console.ReadLine();
                BigInteger a = BigInteger.Parse(input.Split(' ')[0]);
                BigInteger b = BigInteger.Parse(input.Split(' ')[1]);

                Console.WriteLine(a+b);
               
            }
        }
    }
}
