using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercises
{
    class Program
    {
        static void Main()
        {
            List<Exercise> exercises = new List<Exercise>();

            string input = Console.ReadLine();

            while (input != "go go go")
            {
                string[] param = input
                    .Split(new string[] { " -> " },
                           StringSplitOptions.RemoveEmptyEntries);

                string topic = param[0];
                string className = param[1];
                string judgeLink = param[2];
                List<string> problems = param[3]
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                                
                exercises.Add(new Exercise(topic, className, judgeLink, problems));

                input = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");

                Console.WriteLine(
                    $"Problems for exercises and homework for the \"{exercise.ClassName}\" course @ SoftUni.");

                Console.WriteLine($"Check your solutions here: { exercise.JudgeLink}");

                int cnt = 1;
                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine("{0}. {1}", cnt, problem);
                    ++cnt;
                }
            }
        }
    }
    class Exercise
    {
        public string Topic { get; set; }
        public string ClassName { get; set; }
        public string JudgeLink { get; set; }
        public List<string> Problems { get; set; }

        public Exercise(string topic, string className, string judgeLink, List<string> problems)
        {
            Topic = topic;
            ClassName = className;
            JudgeLink = judgeLink;
            Problems = problems;
        }
    }
}