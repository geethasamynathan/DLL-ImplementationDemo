using System;
using CustomerOrderLibarary;

namespace CunstomerOrderServiceTestAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            //  CustomerOrderLibarary.Customer customer = new CustomerOrderLibarary.Customer();
            Customer customer = new Customer();
            customer.GetCustomerInfo();
            customer.DisplayCustomerInfo();
      
        }
    }
}
