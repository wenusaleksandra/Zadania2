using System;
using System.Collections.Generic;
using System.Linq;

namespace LENLCS1
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());
            for (int i = 0; i < liczbaTestow; i++)
            {
                int dlugoscSlowa1 = int.Parse(Console.ReadLine());
                string slowo1 = Console.ReadLine();

                int dlugoscSlowa2 = int.Parse(Console.ReadLine());
                string slowo2 = Console.ReadLine();

                var litery1 = slowo1.ToList<char>().Distinct();
                var litery2 = slowo2.ToList<char>().Distinct();
                //char[] litery1 = slowo1.ToCharArray();
                //char[] litery2 = slowo2.ToCharArray();
                var literyWspolne = new List<char>();
                foreach (var litera1 in litery1)
                {

                    if (litery2.Contains(litera1))
                    {
                        literyWspolne.Add(litera1);
                        //litery1.Remove(litera1);
                        //litery2.Remove(litera1);
                    }
                }
                Console.WriteLine(literyWspolne.Count);
            }
            Console.ReadLine();
        }
    }
}
