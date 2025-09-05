Cat cat = new Cat();
cat.Eat();
cat.Meow();

Dog dog = new Dog();
dog.Eat();
dog.Bark();

Animal animal = new Animal();
animal.Eat();

public class Animal {
    public void Eat() {
        Console.WriteLine("I am eating");
    }
}

public class Dog : Animal {
    public void Bark() {
        Console.WriteLine("I am barking");
    }
}

public class Cat : Animal {
    public void Meow() {
        Console.WriteLine("I am meowing");
    }
}