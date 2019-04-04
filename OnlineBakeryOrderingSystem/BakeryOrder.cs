using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineBakeryOrderingSystem
{
    static class BakeryOrder
    {
        private static List<Bakery> bakeries = new List<Bakery>();

        public static Bakery CreateOrder
    (string customerName, string customerAddress, string customerEmailAddress, string customerBankAccountNumber, BakeryProduct bakeryProduct, int numberOfOrder)
        {
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
                //throw exception
                return null;
            }
            return bakery;
        }
        public static void Order(int customerNumber, int NumberOfOrder)
        {
            Bakery bakery = GetBakeryOrderByCustomerNumber(customerNumber);
            bakery.Order(NumberOfOrder);
        }

    }
}
