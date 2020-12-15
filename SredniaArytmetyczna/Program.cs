using System;

namespace SredniaArytmetyczna
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());
            var tablicaWynikow = new int[liczbaTestow];

            for (int i = 0; i < liczbaTestow; i++)
            {
                string wartosc = Console.ReadLine();
                int n = int.Parse(wartosc.Split(' ')[0]);

                var tablicaLiczb = new int[n];
                decimal suma = 0;
                for (int j = 0; j < n; j++)
                {
                    tablicaLiczb[j] = int.Parse(wartosc.Split(' ')[j + 1]);
                    suma += decimal.Parse(wartosc.Split(' ')[j + 1]);
                }
                decimal srednia = suma / n;
                var roznica = Math.Abs(srednia - tablicaLiczb[0]);
                var liczba = tablicaLiczb[0];
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(srednia - tablicaLiczb[j]) < roznica)
                    {
                        roznica = Math.Abs(srednia - tablicaLiczb[j]);
                        liczba = tablicaLiczb[j];
                    }
                }
                tablicaWynikow[i] = liczba;
            }

            for (int i = 0; i < liczbaTestow; i++)
            {
                Console.WriteLine(tablicaWynikow[i]);
            }
            Console.ReadLine();
        }
    }
}
