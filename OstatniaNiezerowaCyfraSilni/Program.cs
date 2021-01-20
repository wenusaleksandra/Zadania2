using System;
using System.Numerics;

namespace OstatniaNiezerowaCyfraSilni
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaTestow; i++)
            {
                int a = int.Parse(Console.ReadLine());
                var silnia = Silnia(a);
                while (silnia % 10 == 0)
                {
                    silnia = silnia / 10;
                }
                Console.WriteLine(silnia % 10);
            }
        }

        private static BigInteger Silnia(int a)
        {
            BigInteger silnia = 1;
            for (int i = 1; i <= a; i++)
            {
                silnia *= i;
            }
            return silnia;
        }
    }
}
