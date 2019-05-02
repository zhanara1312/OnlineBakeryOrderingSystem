using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBakeryOrderingSystem
{
    public enum TransactionType
    {
        Credit,
        Debit
    }
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Itemprice { get; set; }
        public Int32 NumberOfOrder { get; set; }
        public string Description { get; set; }
        public TransactionType TransactionType { get; set; }

        public int CustomerNumber { get; set; }
        public virtual Bakery Bakery { get; set; }

    }
}
