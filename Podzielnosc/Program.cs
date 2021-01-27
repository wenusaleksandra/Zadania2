using System;
using System.Collections.Generic;

namespace Podzielnosc
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaTestow; i++)
            {
                var input = Console.ReadLine();
                var n = Convert.ToInt32(input.Split(' ')[0]);
                var x = Convert.ToInt32(input.Split(' ')[1]);
                var y = Convert.ToInt32(input.Split(' ')[2]);

                var list = new List<int>();
                for (int  j = 2;  j < n;  j++)
                {
                    if (j % x == 0 && j % y != 0)
                    {
                        list.Add(j);
                    }
                }
                Console.WriteLine(string.Join(' ', list.ToArray()));
            }
        }
    }
}
