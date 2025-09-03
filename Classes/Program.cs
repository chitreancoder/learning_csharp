// See https://aka.ms/new-console-template for more information
using DefaultNamespace;

Customer customer = new Customer("John Doe", "123 Main St");
customer.PrintCustomer();
System.Console.WriteLine("Id: " + customer.Id);

Car car1 = new Car("BMW");
car1.Drive();
