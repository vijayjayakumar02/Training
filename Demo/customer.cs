using System;
using System.Collections.Generic;

namespace Demo
{

    class Customer
    {
        public List<Order> Order;
        private double _walletbalance;

        public double GetWalletBalance()
        {
            return _walletbalance;
        }
        public void SetWalletBalance(double walletbalance)
        {
            _walletbalance = walletbalance;
        }

        public Customer()
        {
            Order = new List<Order>();
        }

        public void AddProduct()
        {
            Order.Add(new Order());
        }
        public int TotalOrder()
        {
            Order.Count();
        }
    }
}