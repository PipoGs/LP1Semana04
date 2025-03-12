using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor("Hello LP1!", '*'));
        }

        private static string Decor(string s, char dec)
        {
            return "{dec}{dec}{dec} {s} {dec}{dec}{dec}";
        }
    }
}
