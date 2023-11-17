using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Gender: {Gender}";
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        Person person = new Person
        {
            Name = "Susan",
            Age = 45,
            Gender = "Female"
        };

        Console.WriteLine(person.ToString());
    }
}
