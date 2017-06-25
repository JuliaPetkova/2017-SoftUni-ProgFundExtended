using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());

            List<int> result = new List<int>();

            for (int j = 1; j <= num; j++)
            {
                int maxvalue = int.MinValue;                                            

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] > maxvalue)
                    {
                        maxvalue = input[i];                        
                    }
                }
                result.Add(maxvalue);

                if (input.Contains(maxvalue))
                {
                    input.Remove(maxvalue);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
