using Dictionaries;

Dictionary<int, string> dictionary = new Dictionary<int, string>();

dictionary.Add(1, "One");
dictionary.Add(2, "Two");
dictionary.Add(3, "Three");

string firstValue = dictionary[1];
Console.WriteLine(firstValue);

dictionary[1] = "Seven";

foreach (KeyValuePair<int, string> item in dictionary)
{
    Console.WriteLine(item.Key + " " + item.Value);
}

if (dictionary.ContainsKey(1))
{
    Console.WriteLine("Key 1 exists");
}
else
{
    Console.WriteLine("Key 1 does not exist");
}

if (dictionary.ContainsValue("Seven"))

    dictionary.Remove(1);

foreach (KeyValuePair<int, string> item in dictionary)
{
    Console.WriteLine(item.Key + " " + item.Value);
}

bool isAdded = dictionary.TryAdd(1, "Eight");
Console.WriteLine(isAdded);

Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

employees.Add(1, new Employee("John", 1000));
employees.Add(2, new Employee("Jane", 2000));
employees.Add(3, new Employee("Jim", 3000));

foreach (KeyValuePair<int, Employee> item in employees)
{
    Console.WriteLine(item.Key + " " + item.Value.Name + " " + item.Value.Salary);
}


 class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Grade { get; set; }

    public Student(int id, string name, int grade)
    {
        Id = id;
        Name = name;
        Grade = grade;
    }

}
 class Exercise
{
    public void PrintStudents()
    {
        var students = new Dictionary<string, Student>();
        students.Add("John", new Student(1, "John", 85));
        students.Add("Alice", new Student(2, "Alice", 90));
        students.Add("Bob", new Student(3, "Bob", 78));

        foreach (KeyValuePair<string, Student> item in students)
        {
            Student student = students[item.Key];

            Console.WriteLine($"Name: {student.Name}, Id: {student.Id}, Grade: {student.Grade}");
        }
    }
}
