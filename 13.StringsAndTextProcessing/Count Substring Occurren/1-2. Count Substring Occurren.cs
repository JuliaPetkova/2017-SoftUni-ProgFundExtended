using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurren
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string patern = Console.ReadLine().ToLower();

            int cnt = 0;
            int index = input.IndexOf(patern);

            while (index != -1)
            {
                cnt++;
                index = input.IndexOf(patern, index + 1);
            }
            Console.WriteLine(cnt);
        }
    }
}
