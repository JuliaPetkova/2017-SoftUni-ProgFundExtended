using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var param = input.Split(new string[] { " -> " }
                , StringSplitOptions.RemoveEmptyEntries).ToArray();

                string text = param[0];
                string[] itemToReplase = param[1].Split(new string[] { ", " }
                , StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < itemToReplase.Length; i++)
                {
                    string placeholder = "{" + i + "}";
                    text = text.Replace(placeholder, itemToReplase[i]);
                }
                Console.WriteLine(text);

                input = Console.ReadLine();

            }
        }
    }
}
