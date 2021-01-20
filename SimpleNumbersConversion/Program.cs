using System;

namespace SimpleNumbersConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaTestow; i++)
            {
                var input = Console.ReadLine();
                var n = input.Split(' ')[0];
                var r = double.Parse(input.Split(' ')[1]);
                var s = int.Parse(input.Split(' ')[2]);

                var liczba = n.ToCharArray();
                var liczbaDziesietnie = 0;
                for (int j = 0; j < liczba.Length; j++)
                {
                    var parsowanie = int.TryParse(liczba[j].ToString(), out int result);
                    
                    if (!parsowanie)
                    {
                        switch (liczba[j].ToString())
                        {
                            case "A":
                                result = 10;
                                break;
                            case "B":
                                result = 11;
                                break;
                            case "C":
                                result = 12;
                                break;
                            case "D":
                                result = 13;
                                break;
                            case "E":
                                result = 14;
                                break;
                            case "F":
                                result = 15;
                                break;
                            case "G":
                                result = 16;
                                break;
                            case "H":
                                result = 17;
                                break;
                            case "I":
                                result = 18;
                                break;
                            case "J":
                                result = 19;
                                break;
                            case "K":
                                result = 20;
                                break;
                            case "L":
                                result = 21;
                                break;
                            case "M":
                                result = 22;
                                break;
                            case "N":
                                result = 23;
                                break;
                            case "O":
                                result = 24;
                                break;
                            case "P":
                                result = 25;
                                break;
                            case "Q":
                                result = 26;
                                break;
                            case "R":
                                result = 27;
                                break;
                            case "S":
                                result = 28;
                                break;
                            case "T":
                                result = 29;
                                break;
                            case "U":
                                result = 30;
                                break;
                            case "V":
                                result = 31;
                                break;
                            case "W":
                                result = 32;
                                break;
                            case "X":
                                result = 33;
                                break;
                            case "Y":
                                result = 34;
                                break;
                            case "Z":
                                result = 35;
                                break;
                        }
                    }
                    
                    liczbaDziesietnie += result * (int)Math.Pow(r, liczba.Length - j - 1);
                }

                var odwrocona = "";
                
                while (liczbaDziesietnie != 0)
                {
                    var reszta = liczbaDziesietnie % s;
                    odwrocona += reszta.ToString();
                    liczbaDziesietnie /= s;
                }
                Console.WriteLine(Reverse(odwrocona));
            }
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
