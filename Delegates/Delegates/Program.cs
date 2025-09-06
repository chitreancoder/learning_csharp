
Person[] people =
{
    new Person { Name = "Juan", Age = 12 },
    new Person { Name = "Antonio", Age = 29 },
    new Person { Name = "Edgar", Age = 13 },
    new Person { Name = "Anto", Age = 50 },
    new Person { Name = "XDS", Age = 89 }
    
};

PersonSorter sorter = new PersonSorter();
sorter.Sort(people, CompareByAge);
sorter.Sort(people, CompareByName);


int CompareByAge(Person x, Person y)
{
    return x.Age.CompareTo(y.Age);
}

int CompareByName(Person x, Person y)
{
    return x.Name.CompareTo(y.Name);
}
public delegate int Comparison<T> (T x, T y);

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class PersonSorter
{
    public void Sort(Person[] persons, Comparison<Person> comparison)
    {
        for (int i = 0; i < persons.Length - 1; i++)
        {
            for (int j = i + 1; j < persons.Length; j++)
            {
                if (comparison(persons[i], persons[j]) > 0)
                {
                    Person temp = persons[i];
                    persons[i] = persons[j];
                    persons[j] = temp;
                }
            }
        }

        for (int i = 0; i < persons.Length - 1; i++)
        {
            Console.WriteLine(persons[i].Age + " " + persons[i].Name);
        }
        
    }
}





























