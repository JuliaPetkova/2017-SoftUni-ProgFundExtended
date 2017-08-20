using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            Dictionary<string, string> login = new Dictionary<string, string>();
            int cnt = 0;

            while (input != "login")
            {
                string[] tokens = input.Split();
                string user = tokens[0];
                string pass = tokens[tokens.Length-1];

                if (!login.ContainsKey(user))
                {
                    login.Add(user, pass);
                }
                else
                {
                    login[user] = pass;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split();
                string user = tokens[0];
                string pass = tokens[tokens.Length - 1];

                if (login.ContainsKey(user) && login.ContainsValue(pass))
                {
                    Console.WriteLine($"{user}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{user}: login failed");
                    cnt++;
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"unsuccessful login attempts: {cnt}");
        }
    }
}
