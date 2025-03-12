using System;

namespace BetterDecorador
{
    public class Program
    {

        /// <summary>
        /// Main method that receives the argument and calls Decor method
        /// to decorate the string with the character and number of times
        /// If no arguments are input, it calls the Decor method that warns the 
        /// user of it
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine(Decor());
            }
            else
            {
                char character = char.Parse(args[1]);
                int number = int.Parse(args[2]);
                Console.WriteLine(Decor(args[0], character, number));
            }
        }

        /// <summary>
        /// This Method receives a string, a character and a number and returns
        /// the string decorated with the character and number of times
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int n)
        {
            string str = Convert.ToString(dec);
            for (int i = n - 1; i > 0; i--)
            {
                str += dec;
            }
            return $"{str} {s} {str}";


        }
        /// <summary>
        /// This method returns a string decorated with "=", 3 times.
        /// </summary>
        /// <returns></returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
