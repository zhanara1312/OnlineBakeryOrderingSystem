﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBakeryOrderingSystem
{
    enum BakeryProduct
    {
        Bread,
        Cakes,
        Cookies 
    }
    class Bakery
    {
        /// <summary>
        /// Online Bakery Ordering System. 
        /// </summary>
        #region Statics
        private static int lastCustomerNumber = 0;
        private static decimal productItemPrice = 5;
        #endregion

            #region Properties
            /// <summary>
            /// Menu, Products like bread
            /// </summary>
            public BakeryProduct BakeryProduct { get; set; } 
            public Decimal ItemPrice { get; private set; }
        /// <summary>
        /// Customer unique number that is assigned when customer creates a profile and orders bread online.
        /// </summary>
            public int CustomerNumber { get; private set; }
            public string CustomerName { get; set; }
            public string CustomerAddress { get; set; }
            public string CustomerEmailAddress { get; set; }
            public string CustomerBankAccountNumber { get; set; }
            public int NumberOfOrder { get; set; }
            public DateTime Date { get; private set; }
            #endregion

            #region Constructor
            public Bakery()
            {
                //lastCustomerNumber++;
                //CustomerNumber = ++lastCustomerNumber;
                CustomerNumber = ++lastCustomerNumber;
                Date = DateTime.Now;
                ItemPrice = productItemPrice;
            }
            #endregion


            #region Methods
            /// <summary>
            /// Calculate order 
            /// </summary>
            /// <param name="NumberOfOrder">Amount with Sales tax included</param>
            public void Order(int NumberOfOrder)
            {
                //ItemPrice = Price * NumberOfOrder
                ItemPrice = ItemPrice *= NumberOfOrder; 
            }
        #endregion
    }
}