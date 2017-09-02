using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_5.SoftUni_Messages__2
{
    class Program
    {
        static void Main(string[] args)
        {
            var patternSnt = @"^\d+[a-zA-Z]+[^a-zA-Z]+$"; // sentances
            var patternMsg = @"[a-zA-Z]+";      //message
            var patternInd = @"\d";         //indexes

            var input = Console.ReadLine();

            while (input != "Decrypt!")
            {
                var matchSnt = Regex.Match(input, patternSnt);
                var matchMsg = Regex.Match(input, patternMsg);
                var index = Regex.Matches(input, patternInd); //collection


                int msgLength = int.Parse(Console.ReadLine());

                if (matchSnt.Success && msgLength == matchMsg.Length)
                {
                    var msg = matchMsg.Value.ToString();

                    string message = "";

                    foreach (Match item in index)
                    {
                        int ind = int.Parse(item.Value);                       

                        if (ind < msgLength)
                        {
                            message = message + msg[ind];
                        }
                    }
                    Console.WriteLine($"{msg} = {message}");

                }
                input = Console.ReadLine();
            }
        }
    }
}
