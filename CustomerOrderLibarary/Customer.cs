using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrderLibarary
{
   public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

         public void GetCustomerInfo()
        {
            Console.WriteLine("enter the CustomerId and Name");
            CustomerId = Convert.ToInt32(Console.ReadLine());
            CustomerName = Console.ReadLine();
        }


        public void DisplayCustomerInfo()
        {
            Console.WriteLine($" Customer Id : {CustomerId}");
            Console.WriteLine($" Customer Name :{CustomerName} ");
        }
    }
}
