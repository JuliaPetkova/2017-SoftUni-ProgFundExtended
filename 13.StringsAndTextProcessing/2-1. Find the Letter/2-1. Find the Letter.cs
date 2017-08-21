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
            string[] search = Console.ReadLine().Split();

            var letter = search[0];
            int n = int.Parse(search[1]);

            var index = -1;

            do
            {
                n--;
                index = input.IndexOf(letter, index + 1);
            } while (index != -1 && n > 0);

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}