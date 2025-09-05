Animal animal = new Animal();
animal.Eat();
animal.MakeSound();
animal.Sleep();

Dog dog = new Dog();
dog.Eat();
dog.Bark();
dog.MakeSound();
dog.Sleep();


public class Animal {

    public int publicField = 1;
    protected int protectedField = 2;
    private int privateField = 3;
    public void Eat() {
        Console.WriteLine("I am eating");
    }
    public virtual void MakeSound() {
        Console.WriteLine("I am making a sound");
    }

    public void Sleep(){
        Console.WriteLine("I am sleeping");
    }
}

public class Dog : Animal {
    public void Bark() {
        Console.WriteLine("I am barking");
    }

    public new void Sleep(){
        base.Sleep();
        Console.WriteLine("I am sleeping loudly");
    }

    public override void MakeSound() {
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