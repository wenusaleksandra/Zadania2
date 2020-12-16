using System;

namespace TransponowanieMacierzy
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            int m = int.Parse(txt.Split(' ')[0]);
            int n = int.Parse(txt.Split(' ')[1]);
            var macierz = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string wiersz = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    macierz[i,j] = int.Parse(wiersz.Split(' ')[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(macierz[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
