using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SrtingRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var num = long.Parse(Console.ReadLine());
            Console.WriteLine(GetRepeatedString(input, num));
        }

        private static string GetRepeatedString(string input, long num)
        {
            string outputString = string.Empty;

            for (int i = 1; i <= num; i++)
            {
                outputString += input;
            }
            return outputString;
        }
    }
}
