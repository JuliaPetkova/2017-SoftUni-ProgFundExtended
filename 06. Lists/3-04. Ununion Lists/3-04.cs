using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_04.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                List<int> addList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                foreach (var item in addList)
                {
                    if (list.Contains(item))
                    {
                        list.Remove(item);
                    }
                    else
                    {
                        list.Add(item);
                    }
                }
            }

            list.Sort();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
