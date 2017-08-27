using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+";                      

            var input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }

            Console.WriteLine();
            //Ivan Ivanov Test Testov
        }
    }
}
