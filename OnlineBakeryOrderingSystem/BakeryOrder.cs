using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBakeryOrderingSystem
{
    static class BakeryOrder
    {
        public static Bakery CreateOrder
    (string customerName, string customerAddress, string customerEmailAddress, string customerBankAccountNumber, int NumberOfOrder)
        {
            var a1 = new Bakery
            {
                CustomerName = customerName,
                CustomerEmailAddress = customerEmailAddress,
                CustomerBankAccountNumber = customerBankAccountNumber
            };
            if (NumberOfOrder > 0)
            {
                a1.Order(NumberOfOrder);
            }
            return a1;

        }
    }
}
