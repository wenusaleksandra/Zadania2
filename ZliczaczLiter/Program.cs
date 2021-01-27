using System;
using System.Text;

namespace ZliczaczLiter
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();
            for (int i = 0; i < liczbaTestow; i++)
            {
                var input = Console.ReadLine();
                sb.Append(input);
            }
            
            for (int j = 97; j <= 122; j++)
            {
                var ilosc = 0;
                foreach (var ch in sb.ToString())
                {
                    if (ch == j) ilosc++;
                }
                if (ilosc != 0) Console.WriteLine((char)j + " " + ilosc);
            }

            for (int j = 65; j <= 90; j++)
            {
                var ilosc = 0;
                foreach (var ch in sb.ToString())
                {
                    if (ch == j) ilosc++;
                }
                if (ilosc != 0) Console.WriteLine((char)j + " " + ilosc);
            }
        }
    }
}
