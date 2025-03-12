using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            char character = char.Parse(args[1]);
            int number = int.Parse(args[2]);

            Console.WriteLine(Decor(args[0], character, number));
        }

        private static string Decor(string s, char dec, int n)
        {
            string str = Convert.ToString(dec);
            for (int i = n - 1; i > 0; i--)
            {
                str += dec;
            }
            return $"{str} {s} {str}";
        }
    }
}
