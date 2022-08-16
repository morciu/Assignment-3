using ConsoleApp1.Employees;

namespace ConsoleApp1.Customers
{
    public class Customer : Person
    {
        private bool _satisfied;

        public virtual void HaveDiner(Waiter waiter)
        {
            Console.WriteLine($"{Name} orders some food");

            // Decide if satisfied with service
            int s = new Random().Next(2);
            _satisfied = s == 0 ? true : false;

            // Tip waiter
            if(_satisfied) {
                int tip = new Random().Next(10, 30);
                waiter.GetTipped(tip);
                Console.WriteLine($"{Name} is satisfied and tips {tip} bucks");
            }
            else
            {
                int tip = new Random().Next(1, 10);
                waiter.GetTipped(new Random().Next(1, 10));
                Console.WriteLine($"{Name} is not satisfied and tips {tip} bucks");
            }
        }
    }
}
