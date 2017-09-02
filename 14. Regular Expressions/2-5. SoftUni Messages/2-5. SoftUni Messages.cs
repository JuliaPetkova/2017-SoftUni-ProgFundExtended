using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_5.SoftUni_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var patternSnt = @"^\d+[a-zA-Z]+[^a-zA-Z]+$";
            var patternMsg = @"[a-zA-Z]+";
            var patternInd = @"\d";

            var input = Console.ReadLine();

            var matchSnt = new Regex(patternSnt);
            var matchMsg = new Regex(patternMsg);
            var matchInd = new Regex(patternInd);

            while (input != "Decrypt!")
            {
                int length = int.Parse(Console.ReadLine());

                if (matchSnt.IsMatch(input))
                {
                    string codeMsg = matchMsg.Match(input).Value;

                    var message = "";

                    var index = matchInd.Matches(input);

                    if (codeMsg.Length == length)
                    {

                        foreach (Match item in index)
                        {
                            int ind = int.Parse(item.Value);

                            if (ind < length )
                            {
                                message = message + codeMsg[ind];
                            }
                        }
                        Console.WriteLine($"{codeMsg} = {message}");

                    }
                }
                input = Console.ReadLine();
            }

        }
    }
}
