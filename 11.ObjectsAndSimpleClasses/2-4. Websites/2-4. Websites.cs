using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4.Websites
{

    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Que { get; set; }

        public Website(string host, string domain, List<string> que)
        {
            Host = host;
            Domain = domain;
            Que = que;
        }
    }
    class Web
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public Web(string host, string domain)
        {
            Host = host;
            Domain = domain;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Website> websites = new List<Website>();
            List<Web> webs = new List<Web>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var param = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (param.Length == 3)
                {
                    string host = param[0];
                    string domain = param[1];
                    var que = param[2]
                           .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    Website web = new Website(host, domain, que);

                    if (!websites.Contains(web))
                    {
                        websites.Add(web);
                    }
                }
                else
                {
                    string host = param[0];
                    string domain = param[1];
                    Web www = new Web(host, domain);

                    if (!webs.Contains(www))
                    {
                        webs.Add(www);
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                Console.Write($"https://www.{ website.Host}.{website.Domain}");
                Console.Write("/query?=[{0}]", string.Join("]&[", website.Que));
                Console.WriteLine();
            }

            foreach (var web in webs)
            {
                Console.Write("https://www.{0}.{1}", web.Host, web.Domain);

            }
        }
    }
}
