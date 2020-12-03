using System;

namespace LENLCS1
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());
            var tablicaWynikow = new int[liczbaTestow];

            for (int t = 0; t < liczbaTestow; t++)
            {
                int dlugoscSlowa1 = int.Parse(Console.ReadLine());
                string slowo1 = Console.ReadLine();

                int dlugoscSlowa2 = int.Parse(Console.ReadLine());
                string slowo2 = Console.ReadLine();

                var C = new int[dlugoscSlowa1 + 1,dlugoscSlowa2 + 1];

                for (int i = 0; i <= dlugoscSlowa1; i++)
                {
                    C[i,0] = 0;
                }
                for (int j = 0; j <= dlugoscSlowa2; j++)
                {
                    C[0,j] = 0;
                }

                for (int i = 1; i <= dlugoscSlowa1; i++)
                {
                    for (int j = 1; j <= dlugoscSlowa2; j++)
                    {
                        if (slowo1[i - 1] == slowo2[j - 1]) C[i, j] = C[i - 1, j - 1] + 1;
                        else C[i, j] = Math.Max(C[i - 1, j], C[i, j - 1]);
                    }
                }
                        
                tablicaWynikow[t] = C[dlugoscSlowa1, dlugoscSlowa2];
            }

            for (int i = 0; i < liczbaTestow; i++)
            {
                Console.WriteLine(tablicaWynikow[i]);
            }
            Console.ReadLine();
        }
    }
}
