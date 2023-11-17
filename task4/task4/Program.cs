using System;

public abstract class Animal
{
    public abstract void Speak();
    public abstract void Move();
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog says gav");
    }

    public override void Move()
    {
        Console.WriteLine("dog walks on 4 paws");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat says meows");
    }

    public override void Move()
    {
        Console.WriteLine("cat walks on 4 paws");
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.Speak();
        dog.Move();

        cat.Speak();
        cat.Move();
    }
}
