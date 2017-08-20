using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1.Find_the_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var searched = Console.ReadLine().Split().ToArray();

            string letter = searched[0];
            int number = int.Parse(searched[1]);
        }
    }
}
