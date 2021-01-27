using System;

namespace NowaDzialka
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaTestow; i++)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(input * input);
            }
        }
    }
}
