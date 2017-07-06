using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var realNumbers = Console.ReadLine().Split();

            var result = new List<char>();

            for (int i = 0; i < realNumbers.Length; i++)
            {
                var index = realNumbers[i].IndexOf('.');
                var firstNum = int.Parse(realNumbers[i].Substring(0, index));
                var secondNum = int.Parse(realNumbers[i].Substring(index + 1));

                if (firstNum != 0)
                {
                    var firstLetter = (char)firstNum;
                    result.Insert(i, firstLetter);
                }

                if (secondNum != 0)
                {
                    var secondLetter = (char)secondNum;
                    result.Insert(result.Count - 1 - i, secondLetter);
                }
            }

            result.Reverse();
            Console.WriteLine(string.Join(string.Empty, result));
        }
    }
}
