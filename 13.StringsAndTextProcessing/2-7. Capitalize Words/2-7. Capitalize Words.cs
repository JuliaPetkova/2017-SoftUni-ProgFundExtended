using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7.Capitalize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> param = input.Split(new[] { '!', ' ', '?', '.', ',', ':' }
                , StringSplitOptions.RemoveEmptyEntries).ToList();

                List<string> words = new List<string>();

                foreach (var item in param)
                {
                   var items = item.Substring(0, 1).ToUpper() +
                        (item.Substring(1, item.Length - 1)).ToLower();

                    words.Add(items);
                }

                Console.WriteLine(string.Join(", ", words));


                input = Console.ReadLine();
            }
        }
    }
}
