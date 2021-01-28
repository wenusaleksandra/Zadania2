using System;

namespace RownanieKwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;
                
                var a = Convert.ToDecimal(input.Split(' ')[0]);
                var b = Convert.ToDecimal(input.Split(' ')[1]);
                var c = Convert.ToDecimal(input.Split(' ')[2]);
                decimal delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("0");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("1");
                }
                else if (delta > 0)
                {
                    Console.WriteLine("2");
                }
            }
        }
    }
}
