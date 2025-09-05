Dog dog = new Dog();
dog.Bark();
dog.Hunt();


abstract class Animal
{


    public abstract void Hunt();
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("I am barking");
    }


    public override void Hunt()
    {
        Console.WriteLine("I am hunting");
    }


}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("I am meowing");
    }

    public override void Hunt()
    {
        Console.WriteLine("I am hunting");
    }
}