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

        public decimal Balance { 
            get{
                decimal balance = 0;
                foreach(var item in AllTransactions)
                {
                    balance +=item.Amount;

                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transactions> AllTransactions = new List<Transactions>();  

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "initial deposit");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, String note) 
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");

            }
            var deposit = new Transactions(amount, date, note); 
            AllTransactions.Add(deposit);   
        }
        public void MakeWithdrawal(decimal amount, DateTime date, String note)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdarawal must be positive");
                
            }
            if (Balance-amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");

            }
            var withdrawal = new Transactions(-amount, date, note);
            AllTransactions.Add(withdrawal);
        }
    }
}
