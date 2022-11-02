using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance { get 
            {
                decimal balance = 0;
                foreach(var item in AllTransactions)
                {
                    balance = +item.Amount;

                }
            }
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transactions> AllTransactions = new List<Transactions>();  

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;  
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, String note) 
        {
        }
        public void MakeWithdrawal(decimal amount, DateTime date, String note)
        {

        }
    }
}
