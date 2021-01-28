using System;

namespace WspolliniowoscPunktow
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaTestow; i++)
            {
                var input = Console.ReadLine();
                var xa = Convert.ToInt32(input.Split('\t')[0]);
                var ya = Convert.ToInt32(input.Split('\t')[1]);
                var xb = Convert.ToInt32(input.Split('\t')[2]);
                var yb = Convert.ToInt32(input.Split('\t')[3]);
                var xc = Convert.ToInt32(input.Split('\t')[4]);
                var yc = Convert.ToInt32(input.Split('\t')[5]);
                if ((xb - xa) * (yc - ya) == (yb - ya) * (xc - xa))
                {
                    Console.WriteLine("TAK");
                }
                else Console.WriteLine("NIE");
            }
        }
    }
}
