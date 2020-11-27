using System;

namespace LiczbyZnaczace
{
    class Program
    {
        private static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            int[] pierwsze = new int[(int)Math.Sqrt(1000000000)+1];
            int[] kwadratyPierwszych = new int[(int)Math.Sqrt(1000000000) + 1];
            for (int i = 2; i < Math.Sqrt(1000000000); i++)
            {
                bool pierwsza = CheckNumber(i);
                if (pierwsza)
                {
                    pierwsze[i] = i;
                    kwadratyPierwszych[i] = i * i;
                }
            }

            var tab = new int[t];
            for (int i = 0; i < t; i++)
            {
                string zakres = Console.ReadLine();
                int a = int.Parse(zakres.Split(' ')[0]);
                int b = int.Parse(zakres.Split(' ')[1]);
                int count = 0;
                for (int j = 1; j < Math.Sqrt(1000000000); j++)
                {
                    if (kwadratyPierwszych[j]>=a && kwadratyPierwszych[j]<=b)
                    {
                        count++;
                    }
                }
                //for (int j = 2; j <= Math.Sqrt(b); j++)
                //{
                //    bool pierwsza = CheckNumber(j);
                //    if (pierwsza)
                //    {
                //        var znaczaca = j * j;
                //        if (znaczaca>=a && znaczaca<=b)
                //        {
                //            count++;
                //        }
                //    }
                //}
                tab[i] = count;
                
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.ReadLine();
        }

        private static bool CheckNumber(int number)
        {
            for (int i = 2; i < number; i++)
                if (number % i == 0)
                {
                    return false;
                }
            return true;
        }
    }
}
