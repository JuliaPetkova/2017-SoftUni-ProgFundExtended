using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_02.Append_Lists_2_ver._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
           
            List<string> newList = new List<string>();
            for (int cnt = 0; cnt < input.Count; cnt++)
            {
                newList = 
            }
            Console.WriteLine(string.Join(" ", newList));

        }
    }
}
