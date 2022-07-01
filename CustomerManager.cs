using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added : " + customer.CustomerName);
        }
        public void Deleted(Customer customer)
        {
            Console.WriteLine("Deleted : " + customer.CustomerName);
        }

        public void List(Customer customer)
        {
            Console.WriteLine("List : " + customer.CustomerName);
        }
    }
}
