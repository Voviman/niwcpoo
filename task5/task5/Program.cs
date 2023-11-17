using System;

public interface IVehicle
{
    void StartEngine();
    void StopEngine();
    void Accelerate();
    void Brake();
}

public class Car : IVehicle
{
    public void StartEngine()
    {
        Console.WriteLine("the car started the engine");
    }

    public void StopEngine()
    {
        Console.WriteLine("the car stopped the engine");
    }

    public void Accelerate()
    {
        Console.WriteLine("the car is accelerating");
    }

    public void Brake()
    {
        Console.WriteLine("the car is braking");
    }
}

public class Truck : IVehicle
{
    public void StartEngine()
    {
        Console.WriteLine("the truck started the engine");
    }

    public void StopEngine()
    {
        Console.WriteLine("the truck stopped the engine");
    }

    public void Accelerate()
    {
        Console.WriteLine("the truck is accelerating");
    }

    public void Brake()
    {
        Console.WriteLine("the truck is braking");
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        IVehicle car = new Car();
        IVehicle truck = new Truck();

        car.StartEngine();
        car.Accelerate();
        car.Brake();
        car.StopEngine();

        truck.StartEngine();
        truck.Accelerate();
        truck.Brake();
        truck.StopEngine();
    }
}
