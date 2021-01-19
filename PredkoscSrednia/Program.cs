using System;

namespace PredkoscSrednia
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaTestow; i++)
            {
                string input = Console.ReadLine();
                int v1 = int.Parse(input.Split(' ')[0]);
                int v2 = int.Parse(input.Split(' ')[1]);
                var predkoscSrednia = 2 * v1 * v2 / (v1 + v2);
                Console.WriteLine(predkoscSrednia);
            }
        }
    }
}
