using ConsoleApp1;
using ConsoleApp1.Customers;
using ConsoleApp1.Employees;

// Customer List
List<Customer> hungryPeople = new List<Customer> {
    new Customer() { Name = "John Wayne" },
    new ChildCustomer() { Name = "Macaulay Culkin" },
    new Customer() { Name = "Joe Pesci" },
    new ChildCustomer() { Name = "Corey Feldman" },
    new Customer() { Name = "Dick Miller" },
    new ChildCustomer() { Name = "Heather O'Rourke" },
    new Customer() { Name = "James Karen" },
    new Customer() { Name = "Robert Englund" },
};

// Employee list
Restaurant restaurant = new Restaurant(new List<Employee>()
{
    new Waiter() { Name = "Monty"},
    new Waiter() { Name = "Serena"},
    new Waiter() { Name = "Mitch"},
    new Waiter() { Name = "Dean"},
    new Cook() { Name = "Calvin"},
    new Cook() { Name = "Raddimus"},
    new Cook() { Name = "Floyd" },
    new Manager() { Name = "David"}
})
{ RestaurantName = "The Crusty Crab"};


// Employees start working
int customerCounter = 0;

Console.WriteLine("Restaurant is open and employees are working.");
foreach(Employee employee in restaurant)
{
    if (employee.GetType() == typeof(Waiter))
    {
        employee.Work();
        hungryPeople[customerCounter].HaveDiner((Waiter)employee);
        hungryPeople[customerCounter+1].HaveDiner((Waiter)employee);
        customerCounter += 2;
        Console.WriteLine("\n");
    }
    else
    {
        employee.Work();
    }
}

// Check how much each employee earned
Console.WriteLine("\nEmployee earnings:");
foreach(Employee employee in restaurant)
{
    employee.EndWorkDay();
}

// New manager
Console.WriteLine("\nNew manager shows up");
Manager newManager = new Manager() { Name = "Boris Karloff" };
newManager.CloseRestaurant();
newManager.CloseRestaurant(50);

// Cloning restaurant
var restauratClone = restaurant.Clone();

Console.WriteLine(restauratClone);