using ConsoleApp1.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Employees
{
    public class Waiter : Employee
    {
        private int _tipsEarned = 0;
        private int _salary = Employee._minimumWage;

        public override void Work()
        {
            Console.WriteLine($"{Name} is waiting tables.");
        }

        public void GetTipped(int tipAmmount)
        {
            _tipsEarned += tipAmmount;
        }

        public override void EndWorkDay()
        {
            Console.WriteLine($"{Name} the waiter earned {_salary + _tipsEarned} today");
        }
    }
}
