using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4.Websites
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Web> websites = new List<Web>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] param = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                string host = param[0];
                string domain = param[1];


                List<string> query = param[3].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
                websites.Add(new Web(host, domain, query));



                input = Console.ReadLine();
            }

            foreach (var item in websites)
            {
                Console.Write($"https://www.{item.Host}.{item.Domain}");

                if (item.Query.Count > 0)
                {
                    Console.Write("/query?=[{0}]", string.Join("]&[", item.Query));
                }

                Console.WriteLine();
            }
        }
    }
    class Web
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Query { get; set; }

        public Web(string host, string domain, List<string> query)
        {
            Host = host;
            Domain = domain;
            Query = query;
        }
    }
}
