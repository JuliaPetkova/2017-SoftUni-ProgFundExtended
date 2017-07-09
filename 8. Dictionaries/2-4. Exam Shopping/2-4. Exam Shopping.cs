using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4.Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            SortedDictionary<string, int> stock = new SortedDictionary<string, int>();

            while (input[0] == "stock")
            {
                int quantity = int.Parse(input[2]);

                if (stock.ContainsKey(input[1]))
                {
                    stock[input[1]] += quantity;
                }
                else
                {
                    stock.Add(input[1], quantity);
                }

                input = Console.ReadLine().Split();

                if (input[0] == "shopping")
                {
                    break;
                }
            }

            input = Console.ReadLine().Split();

            while (input[0] == "buy")
            {
                int quantity = int.Parse(input[2]);

                if (stock.ContainsKey(input[1]))
                {
                    if (stock[input[1]] > 0)
                    {
                        stock[input[1]] -= quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{input[1]} out of stock");
                    }
                }
                else
                {
                    Console.WriteLine($"{input[1]} doesn't exist");
                }

                input = Console.ReadLine().Split();

                if (input[0] == "exam")
                {
                    break;
                }
            }

            foreach (KeyValuePair<string, int> item in stock)
            {
                {
                    if (item.Value > 0)
                    {
                        Console.WriteLine($"{item.Key}-->{item.Value}");
                    }
                }
            }
        }
    }
}
