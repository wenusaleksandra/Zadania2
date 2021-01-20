using System;
using System.Numerics;

namespace SimpleNumbersConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaTestow; i++)
            {
                string input = Console.ReadLine();
                string n = input.Split(' ')[0];
                double r = double.Parse(input.Split(' ')[1]);
                int s = int.Parse(input.Split(' ')[2]);

                var liczba = n.ToCharArray();
                double liczbaDziesietnie = 0;
                for (int j = 0; j < liczba.Length; j++)
                {
                    Convert.ToInt64(liczba[j], 16);
                    liczbaDziesietnie += int.Parse(liczba[j].ToString()) * Math.Pow(r, liczba.Length - j - 1);
                }
                Console.WriteLine(liczbaDziesietnie);
            }
        }
    }
}
