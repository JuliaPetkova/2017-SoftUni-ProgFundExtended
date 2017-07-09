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
            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, string> login = new Dictionary<string, string>();
            int cnt = 0;

            while (input[0] != "login")
            {
                if (!login.ContainsKey(input[0]))
                {
                    login.Add(input[0], input[1]);
                }
                else
                {
                    login[input[0]] = input[1];
                }

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {

                if (login.ContainsKey(input[0]) && login.ContainsValue(input[1]))
                {
                    Console.WriteLine($"{input[0]}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{input[0]}: logged in failed");
                    cnt++;
                }

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            }

            Console.WriteLine($"unsuccessful login attempts: {cnt}");
        }
    }
}
