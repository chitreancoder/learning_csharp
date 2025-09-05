Cat cat = new Cat();
cat.Eat();
cat.Meow();

Dog dog = new Dog();
dog.Eat();
dog.Bark();

Animal animal = new Animal();
animal.Eat();

public class Animal {

    public int publicField = 1;
    protected int protectedField = 2;
    private int privateField = 3;
    public void Eat() {
        Console.WriteLine("I am eating");
        Console.WriteLine(publicField);
        Console.WriteLine(protectedField);
        Console.WriteLine(privateField);
    }
}

public class Dog : Animal {
    public void Bark() {
        Console.WriteLine("I am barking");
    }

    public void AccessFields() {
        publicField = 4;
        protectedField = 5;
        // privateField = 6;
    }
}

public class Cat : Animal {
    public void Meow() {
        Console.WriteLine("I am meowing");
    }
}