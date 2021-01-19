using System;

namespace NotSoFastMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var A = new int[n];

            for (int i = 0; i < n; i++)
            {
                var liczba = int.Parse(Console.ReadLine());
                A[i] = liczba;
            }

            int k = int.Parse(Console.ReadLine());
            var I = new int[k];
            for (int i = 0; i < k; i++)
            {
                var liczba = int.Parse(Console.ReadLine());
                I[i] = liczba;
            }

            for (int i = 0; i < I.Length; i++)
            {
                var mniejsze = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j]<I[i])
                    {
                        mniejsze++;
                    }
                }
                Console.WriteLine(mniejsze);
            }
        }
    }
}
