using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsolationTasks
{
    internal class BankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance { get; set; }

        public BankAccount (string accountNumber, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

        public decimal deposit (decimal amount)
        {
            amount =this.Balance+ amount;
            return amount;
        }
        public decimal withdraw(decimal amount)
        {
            amount =this.Balance- amount;
            return amount;
        }

    }
}
