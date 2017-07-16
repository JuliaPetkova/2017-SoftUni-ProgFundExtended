using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1.Registered_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var usersData = new Dictionary<string, DateTime>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split();
                var username = tokens[0];
                var datetime = DateTime.ParseExact(tokens[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                usersData[username] = datetime;

                input = Console.ReadLine();
            }

            var orderedUsersdata = usersData.Reverse().OrderBy(x => x.Value).Take(5).OrderByDescending(x => x.Value);            


            foreach (var item in orderedUsersdata)
            {
                Console.WriteLine(string.Join("", item.Key));

            }
        }
    }
}
