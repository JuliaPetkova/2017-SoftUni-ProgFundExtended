using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_2.Word_Encounter
{
    class Program
    {
        static char letter;
        static int occurancy;

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            letter = input[0];
            occurancy = input[1] - '0';

            input = Console.ReadLine();

            var output = new List<string>();

            while (input != "end")
            {
                if (IsSentance(input))
                {
                    var pattern = @"\b\w+\b"; // дали има думи

                    var match = Regex.Matches(input, pattern);

                    var matches = match.Cast<Match>().Select(v => v.Value).ToList();

                    foreach (string word in matches)
                    {
                        if (IsWord(word))
                        {
                            output.Add(word);
                        }
                    }

                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", output));
        }

        static bool IsWord(string word)
        {
            int cnt = 0;
            int index = word.IndexOf(letter);

            while (index != -1)
            {
                index = word.IndexOf(letter, index + 1);
                cnt++;
            }
            bool isWord = (cnt >= occurancy);

            return isWord;
        }

        static bool IsSentance(string input)
        {
            var pattern = @"^[A-Z].*[\.!\?]$";
            var regex = new Regex(pattern);

            return regex.IsMatch(input);
        }
    }
}
