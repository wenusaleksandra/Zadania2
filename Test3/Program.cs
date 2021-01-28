using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ilosc = 0;
            var input = "42";

            while (ilosc != 3)
            {
                var input2 = Console.ReadLine();
                if (input != "42" && input2 == "42") ilosc++;
                input = input2;
                Console.WriteLine(input2);
            }
        }
    }
}
