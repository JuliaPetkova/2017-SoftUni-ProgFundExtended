using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> age = new Dictionary<string, int>();
            Dictionary<string, double> salary = new Dictionary<string, double>();
            Dictionary<string, string> position = new Dictionary<string, string>();

            while (input[0] != "filter")
            {
                if (true)
                {

                }
                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            if (input[0] == "Position")
            {

            }
        }
    }
}
