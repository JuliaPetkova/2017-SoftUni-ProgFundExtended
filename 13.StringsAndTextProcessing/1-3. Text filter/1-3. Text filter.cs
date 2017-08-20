using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3.Text_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var banned = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var input = Console.ReadLine();
            
            foreach (var item in banned)
            {
                input = input.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(input);
        }
    }
}
