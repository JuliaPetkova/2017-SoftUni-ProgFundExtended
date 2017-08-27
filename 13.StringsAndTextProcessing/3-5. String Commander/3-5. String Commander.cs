using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5.String_Commander
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var param = command.Split();
                var comm = param[0];

                switch (comm)
                {
                    case "Delete":
                        var start = int.Parse(param[1]);
                        var numSymbols = int.Parse(param[2]);
                        input = input.Remove(start, numSymbols - start + 1);
                        break;



                    case "Insert":
                        var index = int.Parse(param[1]);
                        var insString = param[2];

                        input = input.Insert(index, insString);
                        break;

                    case "Left":
                        int cntL = int.Parse(param[1]);

                        cntL %= input.Length; //cntL = cntL % input.Length;
                        input = input.Substring(cntL) + input.Substring(0, cntL);
                        break;

                    case "Right":
                        int cntR = int.Parse(param[1]);

                        cntR %= input.Length;
                        input = input.Substring(input.Length - cntR)
                            + input.Substring(0, input.Length - cntR);

                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(input);
        }
    }
}
