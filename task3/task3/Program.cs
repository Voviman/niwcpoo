using System;

public class PersonEncapsulation
{
    private int _age;
    private string _name;

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public void SetAge(int age)
    {
        _age = age;
    }

    public int GetAge()
    {
        return _age;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void DisplayAge()
    {
        Console.WriteLine($"Age: {_age}");
    }

    public void DisplayName()
    {
        Console.WriteLine($"Name: {_name}");
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        PersonEncapsulation person = new PersonEncapsulation();

        Console.Write("Enter name: ");
        person.SetName(Console.ReadLine());

        Console.Write("Enter age: ");
        person.SetAge(int.Parse(Console.ReadLine()));

        person.DisplayName();
        person.DisplayAge();
    }
}
