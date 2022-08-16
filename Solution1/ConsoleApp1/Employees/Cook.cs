using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Employees
{
    public class Cook : Employee
    {
        private int _salary = Employee._minimumWage + 100;

        public override void Work()
        {
            Console.WriteLine($"{Name} cooks some food");
        }

        public override void EndWorkDay()
        {
            Console.WriteLine($"{Name} the cook earned {this._salary} bucks today");
        }
    }
}
