using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class BankAccount
    {
        private static long accountNumberSeed = 122333444455555;
        public string AccNum { get;  }
        public string Owner { get; set; }
        public Decimal Balance 
        { 
            get
            {
                decimal balance = 0M;
                foreach (var item in tr)
                {
                    balance += item.Amount;
                    balance -= item.Amount;
                }

                return balance; 
            }
        }

        private List<Transaction> tr = new List<Transaction>();
        public BankAccount(string name, decimal iniBalance)
        {
            AccNum = accountNumberSeed.ToString();
            Owner = name;

            Deposit(iniBalance,DateTime.Now,"Initial Deposit");

            accountNumberSeed++;
        }

        public BankAccount()
        {
            AccNum = null;
            Owner = null;
            Deposit(0M, default(DateTime), null);
        }
        public void Deposit(decimal amount, DateTime date, string description)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, description);
            tr.Add(deposit);
        }

        public void withdrawal(decimal amount, DateTime date, string description)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, description);
            tr.Add(withdrawal);
        }
    }

}
