using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6.Stateless
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "collapse")
                {
                    return;
                }

                var fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    input = input.Replace(fiction, string.Empty);

                    if (fiction.Length == 1)
                    {
                        input = input.Replace(fiction, string.Empty);
                        break;
                    }

                    fiction = fiction.Substring(1, fiction.Length - 2);
                }

                if (input.Length == 0)
                {

                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(input);
                }

            }
        }
    }
}