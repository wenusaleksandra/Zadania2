using System;
using System.Collections.Generic;

namespace PreczZKomentarzami
{
    class Program
    {
        static void Main(string[] args)
        {
            var wierzcholki = new List<string>();
            var krawedzie = new List<List<string>>();
            var listySasiedztwa = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == null || input == string.Empty)
                {
                    break;
                }
                
                string znak = input.Split(' ')[0];
                string wierzcholek1 = input.Split(' ')[1];
                string wierzcholek2 = input.Split(' ')[2];

                if (znak == "B")
                {
                    krawedzie.Add(new List<string> { wierzcholek1, wierzcholek2 });

                    if (!listySasiedztwa.ContainsKey(wierzcholek1))
                    {
                        listySasiedztwa.Add(wierzcholek1, new List<string>());
                    }
                    if (!listySasiedztwa.ContainsKey(wierzcholek2))
                    {
                        listySasiedztwa.Add(wierzcholek2, new List<string>());
                    }

                    listySasiedztwa[wierzcholek1].Add(wierzcholek2);
                    listySasiedztwa[wierzcholek2].Add(wierzcholek1);

                    if (!wierzcholki.Contains(wierzcholek1))
                    {
                        wierzcholki.Add(wierzcholek1);
                    }
                    if (!wierzcholki.Contains(wierzcholek2))
                    {
                        wierzcholki.Add(wierzcholek2);
                    }
                }

                if (znak == "T")
                {
                    if (!wierzcholki.Contains(wierzcholek1) || !wierzcholki.Contains(wierzcholek2))
                    {
                        Console.WriteLine("N");
                        continue;
                    }

                    var wynik = BFS (wierzcholek1, wierzcholek2, wierzcholki, listySasiedztwa);
                    if (wynik)
                    {
                        Console.WriteLine("T");
                    }
                    else Console.WriteLine("N");
                }
            }
        }

        private static bool BFS (string s, string k, List<string> wierzcholki, Dictionary<string, List<string>> listySasiedztwa)
        {
            var flagDict = new Dictionary<string, bool>();
            
            foreach (var v in wierzcholki)
            {
                flagDict[v] = false;
            }

            var q = new Queue<string>();
            flagDict[s] = true;
            q.Enqueue(s);
            while (q.Count > 0)
            {
                var v = q.Dequeue();
                if (v == k)
                {
                    return true;
                }
                foreach (var w in listySasiedztwa[v])
                {
                    if (flagDict[w] == false)
                    {
                        flagDict[w] = true;
                        q.Enqueue(w);
                    }
                }
            }
            return false;
        }
    }
}
