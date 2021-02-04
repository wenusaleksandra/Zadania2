using System;

namespace TagiHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                string converted = "";
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 60)
                    {
                        while (input[i] != 62)
                        {
                            if (input[i] >=97 && input[i] <= 122)
                            {
                                converted += input[i].ToString().ToUpper();
                            }
                            else converted += (char)input[i];
                            i++;
                        }
                    }
                    converted += (char) input[i];
                }
                Console.WriteLine(converted);
            }
        }
    }
}
