using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class Transactions
    {
        public Decimal Amount { get;}
        public DateTime Date { get;}
        public String Notes { get;}

        public Transactions(decimal amount, DateTime date, String note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
