using System;
using System.Collections.Generic;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaWynikow = new List<int>();
            string txt;
            while ((txt = Console.ReadLine()) != null)
            {
                string znak = txt.Split(' ')[0];
                int liczba1 = int.Parse(txt.Split(' ')[1]);
                int liczba2 = int.Parse(txt.Split(' ')[2]);

                if (znak == "+")
                {
                    listaWynikow.Add( Convert.ToInt32(liczba1 + liczba2));
                }
                else if (znak == "-")
                {
                    listaWynikow.Add(Convert.ToInt32(liczba1 - liczba2));
                }
                else if (znak == "*")
                {
                    listaWynikow.Add(Convert.ToInt32(liczba1 * liczba2));
                }
                else if (znak == "/")
                {
                    listaWynikow.Add(Convert.ToInt32(liczba1 / liczba2));
                }
                else if (znak == "%")
                {
                    listaWynikow.Add(Convert.ToInt32(liczba1 % liczba2));
                }
            }
            foreach (var item in listaWynikow)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
