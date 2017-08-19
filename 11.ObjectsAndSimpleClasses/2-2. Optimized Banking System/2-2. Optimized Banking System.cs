using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2.Optimized_Banking_System
{
    class Account
    {
        public string Bank { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }

        public Account(string bank, string accName, decimal accBalance)
        {
            Bank = bank;
            AccountName = accName;
            Balance = accBalance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            var input = Console.ReadLine();
            while (input != "end")
            {
                string[] param = input.Split(new string[] { " | " }, 
                    StringSplitOptions.RemoveEmptyEntries).ToArray();

                string bank = param[0];
                string accName = param[1];
                decimal accBalance = decimal.Parse(param[2]);

                Account account = new Account(bank, accName, accBalance);
                if (!accounts.Contains(account))
                {
                    accounts.Add(account);
                }

                input = Console.ReadLine();
            }

            var ordAccounts = accounts
                .OrderByDescending(a => a.Balance)
                .ThenBy(a => a.Bank.Length)
                .Distinct();

            foreach (var account in ordAccounts)
            {
                Console.WriteLine($"{account.AccountName} -> {account.Balance} ({account.Bank})");
            }

        }
    }

}
