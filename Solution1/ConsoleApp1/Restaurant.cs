using ConsoleApp1.Customers;
using ConsoleApp1.Employees;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Restaurant : IEnumerable<Employee>
    {
        public string RestaurantName { get; set; }
        private List<Employee> _employees;

        public Restaurant(List<Employee> employees)
        {
            _employees = employees;
        }

        IEnumerator<Employee> IEnumerable<Employee>.GetEnumerator()
        {
            return _employees.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
