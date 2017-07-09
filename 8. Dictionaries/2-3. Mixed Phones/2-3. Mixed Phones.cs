using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                    .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();

            while (input[0] != "Over")
            {
                string dictKey;
                int dictValueFirst;
                int dictValueSecond;

                bool input0isNumber = int.TryParse(input[0], out dictValueSecond);
                bool input1isNumber = int.TryParse(input[1], out dictValueFirst);

                if (input0isNumber && !input1isNumber)
                {
                    dict.Add(input[1], dictValueSecond);
                }

                if (!input0isNumber && input1isNumber)
                {
                    dict.Add(input[0], dictValueFirst);
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
