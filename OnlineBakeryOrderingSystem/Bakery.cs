using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBakeryOrderingSystem
{
    class Bakery
    {
        /// <summary>
        /// Online Bakery Ordering System. 
        /// </summary>
        class Bakery
        {
            #region Properties
            /// <summary>
            /// Menu, Products like bread
            /// </summary>
            public string Menu { get; set; }
            public Decimal ItemPrice { get; set; }
            /// <summary>
            /// Discount. If customer buys products for 50$ or more,
            /// customer receives 5% of discount 
            /// </summary>
            public string DiscountOnItems { get; set; }
            public string CustomerName { get; set; }
            public string CustomerAddress { get; set; }
            public string CustomerEmailAddress { get; set; }
            public int CustomerBankAccountNumber { get; set; }
            public DateTime Date { get; set; }
            #endregion

            #region Methods
            /// <summary>
            /// Calculate order (Item price * sales tax: 2%)
            /// </summary>
            /// <param name="amount">Amount with Sales tax included</param>
            public void Order(decimal amount)
            {
                //ItemPrice = Price * tax (2% or 0.02)
                ItemPrice = ItemPrice *= 0.02
            }
            /// <summary>
            /// Item price - discount (5%)
            /// </summary>
            /// <param name="amount">Amount minus Discount</param>
            public void Discount(decimal amount)
            {
                //Item price * 0.05
                Discount = ItemPrice *= 0.05;
                Total = ItemPrice - Discount;

            }




        }
    }
