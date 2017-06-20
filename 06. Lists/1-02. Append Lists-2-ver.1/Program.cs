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
            var input = Console.ReadLine().Split('|').ToList();
            input.Reverse();

            List<string> newList = new List<string>();

            foreach (var item in input)
            {
                var singleList = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                newList.Add(item);

            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
