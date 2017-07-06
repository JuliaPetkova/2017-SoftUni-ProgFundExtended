using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            List<int> numbers = new List<int>();

            int lastRemovedInt = 0;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                AddingIntegersToList(input, numbers);

                if (input == "bang")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemovedInt}");
                        return;
                    }
                    else
                    {
                        double average = numbers.Average();
                        for (int i = 0; i < numbers.Count; i++)
                        {

                            if (numbers[i] < average)
                            {
                                lastRemovedInt = numbers[i];
                                Console.WriteLine($"shot {lastRemovedInt}");

                                numbers.RemoveAt(i);

                                for (int j = 0; j < numbers.Count; j++)
                                {
                                    numbers[j]--;
                                }
                                break;
                            }
                            if (numbers.Count == 1)
                            {
                                lastRemovedInt = numbers[0];
                                Console.WriteLine($"shot {lastRemovedInt}");
                                numbers.RemoveAt(0);

                            }
                        }
                    }
                }
            }

            if (numbers.Count > 0)
            {
                Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {lastRemovedInt}");
            }
        }

        static void AddingIntegersToList(string input, List<int> numbers)
        {
            if (input != "bang" && input != "stop")
            {
                int number = int.Parse(input);
                numbers.Insert(0, number);
            }

        }
    }
}
