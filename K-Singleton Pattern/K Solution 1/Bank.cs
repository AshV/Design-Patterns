using System.Collections.Generic;

namespace K_Solution_1
{
    public class Bank
    {
        public static Bank instance;
        private List<Account> accounts;

        private Bank()
        {
            accounts = new List<Account>();
        }

        public static Bank getInstance()
        {
            if (instance == null)
                instance = new Bank();
            return instance;
        }

        public void addAccount(Account account)
        {
            accounts.Add(account);
        }

        public void display()
        {
            accounts.ForEach(acc =>
            {
                System.Console.WriteLine(acc);
            });
        }
    }
}