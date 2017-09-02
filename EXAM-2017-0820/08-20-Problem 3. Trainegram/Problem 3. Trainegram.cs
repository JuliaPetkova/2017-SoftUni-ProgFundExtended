using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string pattern = @"^(<\[[^A-Za-z0-9]*\]\.)(\.\[[A-Za-z0-9]*\]\.)*$";
            //  ng pattern = @"^(\<\[[^A-Za-z0-9]*\][\.]{1})+([\.]{1}\[[A-Za-z0-9]*\][\.]{1})*$";

            while (input != "Traincode!")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    Console.WriteLine(string.Join("", match.Value));
                }

                input = Console.ReadLine();
            }
        }
    }
}
