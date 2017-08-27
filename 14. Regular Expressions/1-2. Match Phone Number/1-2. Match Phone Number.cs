using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1_2.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            var pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            var input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            var output = matches.Cast<Match>().Select(match => match.Value).ToArray();

            Console.WriteLine(string.Join(", ", output));

            //+359 2 222 2222, +359-2-222-2222
        }
    }
}
