using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = ".,:;()[]\"'/\\!? ".ToCharArray();  // .,:;()[] "'   \ / ! ? 

           string[] input = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(x => x.Length < 5)
                .OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
