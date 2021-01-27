using System;
using System.Numerics;

namespace Imieniny
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaTestow; i++)
            {
                var input = Console.ReadLine();
                var L = BigInteger.Parse(input.Split(' ')[0]);
                var C = BigInteger.Parse(input.Split(' ')[1]);
                if (L<2)
                {
                    Console.WriteLine("TAK");
                }
                else if (L < 2 || C % (L - 1) == 0)
                {
                    Console.WriteLine("NIE");
                }
                else Console.WriteLine("TAK");
            }
        }
    }
}
