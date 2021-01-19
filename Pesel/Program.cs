using System;

namespace Pesel
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaTestow; i++)
            {
                string input = Console.ReadLine();

                char[] charPesel = input.ToCharArray();
                var sumaIloczynow = charPesel[0] * 1 + charPesel[1] * 3 + charPesel[2] * 7 + charPesel[3] * 9 + charPesel[4] * 1 + charPesel[5] * 3 + charPesel[6] * 7 + charPesel[7] * 9 + charPesel[8] * 1 + charPesel[9] * 3 + charPesel[10] * 1;
                var ostatnia = sumaIloczynow % 10;
                if (ostatnia == 0)
                {
                    Console.WriteLine("D");
                }
                else Console.WriteLine("N");
            }
        }
    }
}
