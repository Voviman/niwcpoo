using System;

public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal says");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("dog barks");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("cat meows");
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        animal.Speak();
        dog.Speak();
        cat.Speak();
    }
}
