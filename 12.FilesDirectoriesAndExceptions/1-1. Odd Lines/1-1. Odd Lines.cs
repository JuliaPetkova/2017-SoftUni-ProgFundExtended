using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _1_1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../input.txt");

            for (int i = 1; i < input.Length; i=i+2)
            {
                File.AppendAllText("outut1.txt", input[i]+"\r\n");
            }
            //var output = input.Where((line, index) => index % 2 != 0);
                        
        }
    }
}
