using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Employees
{
    public class Manager : Employee
    {
        private int _salary = Employee._minimumWage + 2000;

        public override void Work()
        {
            Console.WriteLine($"{Name} tries to look busy");
        }

        public override void EndWorkDay()
        {
            Console.WriteLine($"{Name} the manager earned {_salary} bucks today");
        }

        public void CloseRestaurant()
        {
            Console.WriteLine($"{Name} the manager closes up the restaurant for the day.");
        }

        public void CloseRestaurant(int extraIncome)
        {
            Console.WriteLine($"{Name} the manager takes {extraIncome} from the safe when no one is looking and closes up the restaurant.");
        }
    }
}
