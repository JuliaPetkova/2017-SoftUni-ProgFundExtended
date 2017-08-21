using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string split = Console.ReadLine();
            input = input.Replace(split, ", ");

            Console.WriteLine("[" + input + "]");
        }
    }
}
