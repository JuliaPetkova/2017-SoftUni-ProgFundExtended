using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_02.Append_Lists_2_ver._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().
                Split(new char[] 
                { ' ', '!', '(', ')', ',', '.', '\'', '\"', ':', ';', '[', ']', '\\', '/' }, 
                StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            foreach (var item in input)
            {
                if (item.All(char.IsLower))
                {
                    lowerCase.Add(item);
                }
                else if (item.All(char.IsUpper))
                {
                    upperCase.Add(item);
                }
                else
                {
                    mixedCase.Add(item);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));

        }
    }
}
