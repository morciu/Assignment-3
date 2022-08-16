using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Employees
{
    public class Employee : Person
    {
        public static int _minimumWage = 500;
        private int _salary = _minimumWage;

        public virtual void Work()
        {
            Console.WriteLine($"{Name} starts work");
        }

        public virtual void EndWorkDay()
        {
            Console.WriteLine($"{Name} earned {_salary} bucks today");
        }
    }
}
