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
            var input = Console.ReadLine();
            var search = Console.ReadLine().Split();

            var letter = search[0];
            int occurrence = int.Parse(search[1]);

            int index = -1;

            do
            {
                occurrence--;
                index = input.IndexOf(letter, index + 1);
            } while (index != -1 && occurrence != 0);

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