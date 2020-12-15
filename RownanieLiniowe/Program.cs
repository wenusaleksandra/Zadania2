using System;

namespace RownanieLiniowe
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            decimal a = decimal.Parse(txt.Split(' ')[0]);
            decimal b = decimal.Parse(txt.Split(' ')[1]);
            decimal c = decimal.Parse(txt.Split(' ')[2]);
            if (a == 0)
            {
                if (b == c)
                {
                    Console.WriteLine("NWR");
                }
                else Console.WriteLine("BR");
                return;
            }
            decimal x = Math.Round((c - b) / a, 2);
            Console.WriteLine(x.ToString("N2"));
            Console.ReadLine();
        }
    }
}
