using System;
namespace Abstraction;

/* Abstraction - Hides Complexity , Shows Essential Features

Use:

Interface → behavior only

Abstract class → shared code + behavior

*/





/*
 
EXAMPLE 1.


class Program
{
    static void Main()
    {
        IUserAccount admin = new AdminUser();
        IUserAccount customer = new CustomerUser();

        admin.Login();
        admin.Logout();

        customer.Login();
        customer.Logout();
    }
}

public interface IUserAccount
{
    void Login();
    void Logout();
}

public class AdminUser : IUserAccount
{
    public void Login()
    {
        Console.WriteLine("Admin logged in with full privileges.");
    }

    public void Logout()
    {
        Console.WriteLine("Admin logged out.");
    }
}

public class CustomerUser : IUserAccount
{
    public void Login()
    {
        Console.WriteLine("Customer logged in.");
    }

    public void Logout()
    {
        Console.WriteLine("Customer logged out.");
    }
}

*/
