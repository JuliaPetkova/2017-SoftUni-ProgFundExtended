using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _1_2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            var output = input.Select((line, index) => $"{ index + 1}.   {line}");
            File.WriteAllLines("out.txt", output);

            //for (int i = 0; i < input.Length; i++)
            //{
            //    File.AppendAllText("output.txt", $"{i + 1}. " + input[i] + "\r\n");
            //}

        }
    }
}
