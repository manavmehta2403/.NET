using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra's",10000);

            Console.WriteLine($"{account.AccNum} --> {account.Owner} --> "+
                "{0:C}",account.Balance);
            Console.ReadKey();
        }
    }
}
