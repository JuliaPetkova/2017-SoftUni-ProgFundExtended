using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_05.Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            list1 = AddElementsInList1(input, list1);
            list2 = AddElementsInList2(input, list2);

            //   Console.WriteLine(string.Join(" ", list1));
            //  Console.WriteLine(string.Join(" ", list2));

            List<int> result = new List<int>();


            for (int i = 0; i < result.Count; i += 3)
            {
                var firstdigit = list2[i] / 10;
                result.Add(firstdigit);

                for (int j = 0; j < list1.Count - 3; j += 3)
                {



                    result[j + 1] = list1[i];
                    result.Add(list1[i]);


                    result[j + 2] = seconddigit;
                    result.Add(seconddigit);

                }
                var seconddigit = list2[i] % 10;

            }
            Console.WriteLine(string.Join(" ", result));


        }

        private static List<int> AddElementsInList2(List<int> input, List<int> list2)
        {
            for (int i = input.Count / 2; i < input.Count; i++)
            {
                list2.Add(input[i]);
            }
            return list2;
        }

        private static List<int> AddElementsInList1(List<int> input, List<int> list1)
        {
            for (int i = 0; i < input.Count / 2; i++)
            {
                list1.Add(input[i]);
            }
            return list1;
        }
    }
}
