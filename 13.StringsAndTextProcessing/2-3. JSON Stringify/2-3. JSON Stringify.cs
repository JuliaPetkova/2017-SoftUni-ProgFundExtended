using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3.JSON_Stringify
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int[] Score { get; set; }
        public Student(string name, int age, int[] score)
        {
            this.Name = name;
            this.Age = age;
            this.Score = score;
        }
        public override string ToString()
        {

            return string.Format("{{" + $"name:\"{{0}}\",age:{{1}},grades:[{{2}}"
                , Name, Age, string.Join(", ", Score) + "]}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            int[] score = null;

            while (input != "stringify")
            {
                //   "  ".ToCharArray() e също като    new[]{}  
                //var inpParams = input.Split(new[] { ' ', ':', '-', '>', ',' }
                //, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var inpParams = input.Split( " :->,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string name = inpParams[0];
                int age = int.Parse(inpParams[1]);
                if (inpParams.Length < 2)
                {
                    score = null;
                }
                else
                {
                    score = inpParams.Skip(2).Select(int.Parse).ToArray();
                }
                Student student = new Student(name, age, score);
                students.Add(student);



                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(",", students) + "]");
        }
    }
}
