using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();
            var names = Console.ReadLine().Split().ToArray();

            string singleName ="";

            while (singleName != "done")
            {
                singleName = Console.ReadLine();
                for (int i = 0; i < names.Length; i++)
                {
                    if (singleName == names[i] )
                    {
                        Console.WriteLine($"{names[i]} -> {numbers[i]}");
                        break;
                    }
                }
            }

        }
    }
}
