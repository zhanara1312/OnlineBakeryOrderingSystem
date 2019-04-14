using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineBakeryOrderingSystem
{
    static class BakeryOrder
    {
        private static List<Bakery> bakeries = new List<Bakery>();
        private static List<Transaction> transactions = new List<Transaction>();

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
            (string customerName, string customerAddress, string customerEmailAddress, string customerBankAccountNumber,
             BakeryProduct bakeryProduct, int numberOfOrder)
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
            return a1;
        }

        public static IEnumerable<Bakery> GetBakeryOrderForUser()
        {
            return bakeries;
        }
        private static Bakery GetBakeryOrderByCustomerNumber
            (Int32 customerNumber)
        {
            var bakery = bakeries.SingleOrDefault(a => a.CustomerNumber == customerNumber);
            if (bakery == null)
            {
                throw new ArgumentNullException("bakery", "Customer number is invalid!");
            }
            return bakery;
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

            transactions.Add(transaction);
    }

    }
}
