using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBakeryOrderingSystem
{
    static class BakeryOrder
    {
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
    }
}
