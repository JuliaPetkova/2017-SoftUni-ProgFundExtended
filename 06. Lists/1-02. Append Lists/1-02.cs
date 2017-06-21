using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_02.Append_Lists
{
    class Program
    {
        public static int RemoveEmpt { get; private set; }

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');

            List<string> result = new List<string>();

            input.Reverse();

            foreach (var item in input)
            {
                item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.Add(item);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
