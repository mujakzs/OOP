

public class Employee
{
    private int _id;
    private string _name;
    protected double BaseSalary;

    public int Id => _id;
    public string Name => _name;

    public Employee(int id, string name, double baseSalary)
    {
        _id = id;
        _name = name;
        BaseSalary = baseSalary;
    }

    public abstract double CalculateSalary();

    public virtual void DisplayEmployeeInfo()
    {
        Console.WriteLine($"ID: {_id}, Name: {_name}, Base Salary: {BaseSalary:C}");
    }
}


public class Programmer : Employee
{
    private
}