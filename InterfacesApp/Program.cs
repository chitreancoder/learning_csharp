Dog dog = new Dog();
dog.MakeSound();
dog.Eat("Food");

Cat cat = new Cat();
cat.MakeSound();
cat.Eat("Essen");


public interface IAnimal
{
    void MakeSound();

    void Eat(string food);
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Dog sound");
    }

    public void Eat(string food)
    {
        Console.WriteLine("Dog food");
    }

    
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Cat sound");
    }

    public void Eat(string food)
    {
        Console.WriteLine("Cat food");
    }
}