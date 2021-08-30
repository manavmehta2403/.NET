using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Description { get; }

        public Transaction(decimal amount, DateTime date, string description)
        {
            Amount = amount;
            Date = date;
            Description = description;
        }

        public Transaction()
        {
            Amount = 0M;
            Date = default(DateTime);
            Description = null;
        }
    }
}
