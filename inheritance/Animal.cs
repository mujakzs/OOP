using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance;


//Example 1


/*
 
Inheritance - is ability of one class to acquired the properties and behaviors of another class. It promotes code reusability and establishes a natural hierarchical relationship between classes.

 
public class Program
{
    static void Main()
    {
        Car car = new Car();

        car.Start(); // Inherited from Vehicle
        car.Drive(); // Defined in Car

        Motorcycle motor = new Motorcycle();

        motor.Start(); // Inherited from Vehicle
        motor.Ride(); // Defined in Motorcycle
    }

}

public class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Car is starting...");
    }

    public void stop()
    {
        Console.WriteLine("car is not moving");
    }
}

public class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving...");
    }
}

public class Motorcycle : Vehicle
{
    public void Ride()
    {
        Console.WriteLine("Motorcycle is riding...");
    }
}


*/