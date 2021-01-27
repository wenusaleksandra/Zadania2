using System;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            var liczba = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;
                liczba += Convert.ToInt32(input);
                Console.WriteLine(liczba);
            }
        }
    }
}
