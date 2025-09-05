Person person = new Person("John", 20);

person.PrintPerson();

Employee employee = new Employee("Jane", 30, "HR");
employee.PrintEmployee();

//
//
/// <summary>
/// Person class
/// </summary>
/// <param name="name">Name of the person</param>
/// <param name="age">Age of the person</param>
/// <returns>Person object</returns> 
public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Person created");
    }

    public void PrintPerson()
    {
        Console.WriteLine("Name: " + Name + " Age: " + Age);
    }
}

public class Employee : Person
{
    public string Department { get; private set; }

    public Employee(string name, int age, string department) : base(name, age)
    {
        Department = department;
    }

    public void PrintEmployee()
    {
        Console.WriteLine("Name: " + Name + " Age: " + Age + " Department: " + Department);
    }
}