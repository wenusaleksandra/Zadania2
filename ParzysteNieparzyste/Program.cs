using System;

namespace ParzysteNieparzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < liczbaTestow; i++)
            {
                string input = Console.ReadLine();
                int ilosc = int.Parse(input.Split(' ')[0]);
                var tablicaLiczb = new int[ilosc];
                for (int j = 0; j < ilosc; j++)
                {
                    tablicaLiczb[j] = int.Parse(input.Split(' ')[j+1]);
                }
                
                for (int j = 1; j < ilosc; j += 2)
                {
                   Console.Write( tablicaLiczb[j] + " ");
                }
                for (int j = 0; j < ilosc; j += 2)
                {
                    Console.Write(tablicaLiczb[j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
