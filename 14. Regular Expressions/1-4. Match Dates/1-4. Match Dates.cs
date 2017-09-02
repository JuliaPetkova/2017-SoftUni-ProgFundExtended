using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1_4.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>[0-9]{2})(\/|-|.)(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
                       
            string input = Console.ReadLine();

            MatchCollection datesMatches = Regex.Matches(input, pattern);

            foreach (Match date in datesMatches)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}", day, month, year);

            }
        }
    }
}
