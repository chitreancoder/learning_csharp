namespace DefaultNamespace;

public class Customer
{
	public string Name { get; set; }
	public string Address { get; set; }
	public string Phone { get; set; }

	public Customer() {
		Name = "DEFAULT VALUE";
		Address = "DEFAULT VALUE";
		Phone = "DEFAULT VALUE";
	}

	public Customer(string name, string address, string phone = "DEFAULT VALUE")
	{
		Name = name;
		Address = address;
		Phone = phone;
	}

	public void PrintCustomer()
	{
		Console.WriteLine("Name: " + Name);
		Console.WriteLine("Address: " + Address);
		Console.WriteLine("Phone: " + Phone);
	}
}