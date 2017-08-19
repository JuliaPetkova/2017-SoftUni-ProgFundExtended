using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercises
{
    class Program
    {
        class Exercice
        {
            public string Topic { get; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public List<string> Problems { get; set; }

            public Exercice(string topic, string courseName, string judgeContestLink, List<string> problems)
            {
                Topic = topic;
                CourseName = courseName;
                JudgeContestLink = judgeContestLink;
                Problems = problems;
            }

        }
        static void Main()
        {
            List<Exercice> exercises = new List<Exercice>();

            var input = Console.ReadLine();

            while (input != "go go go")
            {
                string[] param = input
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string topic = param[0];
                string courseName = param[1];
                string judgeContestLink = param[2];

                List<string> problems = param[3].Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                Exercice exersice = new Exercice(topic, courseName, judgeContestLink, problems);
                if (!exercises.Contains(exersice))
                {
                    exercises.Add(exersice);
                }

                input = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                int cnt = 1;
                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{cnt}. {problem}");
                    cnt++;
                }
            }
        }
    }
}