using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3.Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<string>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                set.Add(input);
            }
            Console.WriteLine(string.Join("\n", set));


        }
    }
}
