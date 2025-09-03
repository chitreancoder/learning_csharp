namespace DefaultNamespace;

public class Customer
{
	// Static field to hold the next id
	private static int nextId = 0;
	private readonly int _id;
	public string Name { get; set; }
	public string Address { get; set; }
	public string Phone { get; set; }

	public Customer() {
		_id = nextId++;
		Name = "DEFAULT VALUE";
		Address = "DEFAULT VALUE";
		Phone = "DEFAULT VALUE";
	}

	public Customer(string name, string address, string phone = "DEFAULT VALUE")
	{
		_id = nextId++ + 1;
		Name = name;
		Address = address;
		Phone = phone;
	}

	public void PrintCustomer()
	{
		Console.WriteLine("Name: " + Name);
		Console.WriteLine("Address: " + Address);
		Console.WriteLine("Phone: " + Phone);
		System.Console.WriteLine("Id: " + _id);
	}

	public int Id { get
	{return _id;}
	}
}