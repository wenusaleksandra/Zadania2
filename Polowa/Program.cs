using System;

namespace Polowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaTestow; i++)
            {
                string input = Console.ReadLine();
                var dlugosc = input.Length;
                Console.WriteLine(input.Substring(0, dlugosc / 2));
            }
        }
    }
}
