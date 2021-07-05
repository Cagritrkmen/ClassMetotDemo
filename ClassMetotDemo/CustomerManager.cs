using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerId+": "+customer.CustomerName+"   "+ customer.CustomerSurname+ "        Added to this webpage...");
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Registered Customers ----:    "+customer.CustomerId + "-" + customer.CustomerName + "   " + customer.CustomerSurname );
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + ": " + customer.CustomerName + "   " + customer.CustomerSurname + "         Deleted from this webpage...");
        }
    }
}
