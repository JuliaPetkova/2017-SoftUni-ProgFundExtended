using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1_1.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new Dictionary<string, List<double>>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            foreach (var item in grades)
            {
                var name = item.Key;
                var grade = item.Value;

                double average = grade.Average();

                Console.Write($"{name} -> ");

                foreach (var grd in grade)
                {
                    Console.Write($"{grd:F2} ");
                }
                Console.WriteLine($"(avg: {average:F2})");
                
            }
        }
    }
}
