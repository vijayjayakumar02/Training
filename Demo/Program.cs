using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var Customer = new Customer();
            Customer.AddProduct();
            Customer.AddProduct();
            Customer.TotalOrder();
        }
    }
}
