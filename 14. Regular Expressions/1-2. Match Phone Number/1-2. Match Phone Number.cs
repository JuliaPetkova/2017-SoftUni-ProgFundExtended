using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\+359([? |-])2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, patern);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value, " ");
            }         

        }
    }
}
