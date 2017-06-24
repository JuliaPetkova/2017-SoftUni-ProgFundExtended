using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._02.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string num;

            while ((num = Console.ReadLine()) != "end")
            {

                var index = num[0]- '0'; // изваждам '0', за да вземе цифрата, а не ASKII
                var value = int.Parse(num);
                input.Insert(index, value);

            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
