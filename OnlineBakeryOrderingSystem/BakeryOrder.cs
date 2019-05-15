using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineBakeryOrderingSystem
{
    public static class BakeryOrder
    {
        private static BakeryContext db = new BakeryContext();
        /// <summary>
        /// Creates an account in the bank
        /// </summary>
        /// <param name="customerName">Customer's name</param>
        /// <param name="customerAddress">Customer's address</param>
        /// <param name="customerEmailAddress">Customer's email address</param>
        /// <param name="customerBankAccountNumber">Bank account number of the customer</param>
        /// <param name="bakeryProduct">Bakery product type</param>
        /// <param name="numberOfOrder">Quantity of the order</param>
        /// <returns>Newly created order</returns>
        /// <exception cref="ArgumentNullException" />
        public static Bakery CreateOrder
            (BakeryProduct bakeryProduct, string customerName, string customerEmailAddress, string customerBankAccountNumber,
             int numberOfOrder = 0)
        {
            if (string.IsNullOrEmpty(customerEmailAddress)
                || string.IsNullOrWhiteSpace(customerEmailAddress))
            {
                throw
                    new ArgumentNullException
                    ("emailAddress", "Email Address is required!");
            }        
            var a1 = new Bakery
            {
                CustomerName = customerName,
                CustomerEmailAddress = customerEmailAddress,
                CustomerBankAccountNumber = customerBankAccountNumber,
                BakeryProduct = bakeryProduct, 
                NumberOfOrder = numberOfOrder             
            };
            if (numberOfOrder > 0) 
            {
                a1.Order(numberOfOrder);               
            }
            db.Bakeries.Add(a1);
            db.SaveChanges();
            return a1;
        }

        public static void CreateBakery(BakeryProduct bakeryProduct, string customerName, string customerEmailAddress, string customerBankAccountNumber, int numberOfOrder)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<Bakery> GetBakeryOrderForUser(string customerEmailAddress)
        {
            return db.Bakeries.Where(a => a.CustomerEmailAddress == customerEmailAddress);
        }

        public static IEnumerable<Transaction>
            GetTransactionsForCustomerNumber(Int32 customerNumber)
        {
            return db.Transactions
                .Where(t => t.CustomerNumber == customerNumber)
                .OrderByDescending(t => t.TransactionDate);
        }

        public static Bakery GetBakeryOrderByCustomerNumber
            (int customerNumber)
        {
            var bakery = db.Bakeries.SingleOrDefault(a => a.CustomerNumber == customerNumber);
            if (bakery == null)
            {
                throw new ArgumentNullException("bakery", "Customer number is invalid!");
            }
            return bakery;
        }

        public static Bakery UpdateBakery(Bakery updatedBakery)
        {
            var oldBakery =
                GetBakeryOrderByCustomerNumber(updatedBakery.CustomerNumber);
            oldBakery.CustomerEmailAddress = updatedBakery.CustomerEmailAddress;
            oldBakery.BakeryProduct = updatedBakery.BakeryProduct;
            db.SaveChanges();

            return oldBakery;
        }

        public static void Order(int customerNumber, int NumberOfOrder)
        {
            Bakery bakery = GetBakeryOrderByCustomerNumber(customerNumber);
            bakery.Order(NumberOfOrder);

            var transaction = new Transaction
            {
                TransactionDate = DateTime.Now,
                TransactionType = TransactionType.Credit,
                Description = "Bakery order",
                NumberOfOrder = NumberOfOrder,
                CustomerNumber = customerNumber
            };

            db.Transactions.Add(transaction);
            db.SaveChanges();
        }

    }
}
