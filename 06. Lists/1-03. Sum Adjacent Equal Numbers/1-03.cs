using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            int index = 0;

            while (index < list.Count - 1)
            {
                if (list[index] == list[index + 1])
                {
                    list[index] = list[index] + list[index + 1];
                    list.RemoveAt(index + 1);

                    index--;

                    if (index < 0)
                    {
                        index = 0;
                    }
                }
                else index++;
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }

}


