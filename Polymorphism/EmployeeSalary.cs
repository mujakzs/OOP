using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism;



/*
    EXAMPLE 1.

 Polymorphism - One Interface, Multiple Forms
              - It allows different objects to respond to the same method in different ways.
 */


class Program
{
    static void Main()
    {
        List<IEmployee> employees = new List<IEmployee>
        {
            new FullTimeEmployee { MonthlySalary = 3000, Name = "Andrian"},
            new PartTimeEmployee { HourRate = 20, HoursWorked = 80},
            new ContractEmployee { ProjectRate = 5000}
        };

        foreach (var emp in employees)
        {
            Console.WriteLine($"Employee Salary: {emp.CalculateSalary()}");
            Console.WriteLine("-----------------------------");
        }
    }
}

//interface - contract for employee types
public interface IEmployee
{
    double CalculateSalary();
}

//abstract class - shared logic

public abstract class EmployeeBase : IEmployee   //abstract - meaning it cannot be instantiated directly, but can be inherited by other classes
{
    public string? Name { get; set; }

    public abstract double CalculateSalary();

    protected void PrintEmployeeType(string type)  // shared method to print employee type
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Calculating salary for {type}");
    }
}


//Concrete classes - specific implementations

public class FullTimeEmployee : EmployeeBase
{
    public double MonthlySalary { get; set; }

    public override double CalculateSalary()
    {
        PrintEmployeeType("Full-Time Employee");
        return MonthlySalary;
    }
}

public class PartTimeEmployee : EmployeeBase
{
    public double HourRate { get; set; }
    public int HoursWorked { get; set; }

    public override double CalculateSalary()
    {
        PrintEmployeeType("Part-Time Employee");
        return HourRate * HoursWorked;
    }
}


public class ContractEmployee : EmployeeBase
{
    public double ProjectRate { get; set; }

    public override double CalculateSalary()
    {
        PrintEmployeeType("Contract Employee");
        return ProjectRate;
    }
}





/*
What an abstract class is
    An abstract class is a class that cannot be instantiated directly — you cannot create an object of it.
    It acts as a blueprint or template for other classes.
    Its purpose is to define common structure or behavior that all derived classes should share.
*/