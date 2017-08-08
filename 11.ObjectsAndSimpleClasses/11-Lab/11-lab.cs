using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace _11_Lab
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var students = new Student[]
                {
                new Student() {Name="Vanya", Age=22 },
                new Student(){Name="Paco", Age=21 },
                };

            
            Console.WriteLine(string.Join(", ", students.Select(s => s.Name + " " + s.Age)));
        }

    }
}
