using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_7.Pyramidic
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> lines = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                lines.Add(Console.ReadLine());
            }

            List<string> allPyramids = new List<string>();

            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];

                for (int j = 0; j < line.Length; j++)
                {
                    char symbol = line[j];

                    string pyramid = FindPyramid(symbol, lines, i);

                    allPyramids.Add(pyramid);
                }
            }

            string biggest = allPyramids.OrderByDescending(p => p.Length).First();

            Console.WriteLine(biggest);
        }

        private static string FindPyramid(char symbol, List<string> lines, int lineNumber)
        {
            int count = 3;
            string pyramid = "" + symbol + Environment.NewLine;

            for (int i = lineNumber + 1; i < lines.Count; i++)
            {
                string toFind = new string(symbol, count);

                if (lines[i].Contains(toFind))
                {
                    pyramid += toFind + Environment.NewLine;
                    count += 2;
                }
                else
                {
                    return pyramid;
                }
            }
            return pyramid;
        }
    }
}
