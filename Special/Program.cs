using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insert n-th number of the special sequence: ");
            
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSpecial(n));
        }

        private static int GetSpecial(int n)
        {
            int firstnum = 0;
            int secondnum = 1;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                result = 2 * firstnum + secondnum; 
            }
            
            return  result;
        }
    }
}
