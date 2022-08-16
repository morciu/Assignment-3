using ConsoleApp1.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Customers
{
    internal class ChildCustomer : Customer
    {
        public override void HaveDiner(Waiter waiter)
        {
            Console.WriteLine($"{Name} gets some icecream");
        }
    }
}
