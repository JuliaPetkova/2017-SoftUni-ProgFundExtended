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
            var input = Console.ReadLine();

            Dictionary<string, int> ages = new Dictionary<string, int>();
            Dictionary<string, double> salaries = new Dictionary<string, double>();
            Dictionary<string, string> positions = new Dictionary<string, string>();           
                        
            int age;
            double salary;
            bool isAge = false;
            bool isSalary = false;

            while (input != "filter base")
            {
                var token = input.Split();
                var name = token[0];
                var value = token[2];

                isAge = int.TryParse(value, out age);
                isSalary = double.TryParse(value, out salary);

                if (isAge)
                {
                    isSalary = false;
                    ages[name] = age;
                }

                if (isSalary)
                {
                    isAge = false;
                    salaries[name] = salary;
                }               

                if (isAge == false && isSalary == false)
                {
                    positions[name] = value;
                }        
                                
                input = Console.ReadLine();
            }

            input = Console.ReadLine().ToLower();

            if (input == "position".ToLower())
            {
                foreach (KeyValuePair<string, string> item in positions)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }

            if (input == "salary".ToLower())
            {
                foreach (KeyValuePair<string, double> item in salaries)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Salary: {item.Value:F2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            if (input == "Age")
            {
                foreach (KeyValuePair<string, int> item in ages)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
