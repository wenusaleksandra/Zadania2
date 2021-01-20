using System;

namespace KtoraWieksza
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(input.Split(' ')[0]);
            int b = int.Parse(input.Split(' ')[1]);
            if (a == b)
            {
                Console.WriteLine("0");
            }
            if (a < b)
            {
                Console.WriteLine("2");
            }
            if (a > b)
            {
                Console.WriteLine("1");
            }
        }
    }
}
