using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4.JSON_Parse
{
}
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] param = input.Substring(2, input.Length - 2 - 2).Split(new string[] { "},{" }
        , StringSplitOptions.RemoveEmptyEntries);

        foreach (var item in param)
        {
            string[] student = item.Split(new string[] { "name:\"", "\",age:", ",grades:[" }, StringSplitOptions.RemoveEmptyEntries);
            string name = student[0];
            string age = student[1];
            string grades;

            if (student[2] =="]")
            {
                grades = "None";
            }
            else
            {
                grades = student[2].Substring(0, student[2].Length-1);

            }

            Console.WriteLine($"{name} : {age} -> {grades}");

        }


    }
}

