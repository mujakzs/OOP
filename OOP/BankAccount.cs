using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation;

class Program
{
    static void Main()
    {
       
    }
}

public class BankAccount
{
    //hidden data - fields
    private double Balance;

    //Constructor
    public BankAccount(double initialBalance)
    {
        if (initialBalance >= 0)
        {
            Balance = initialBalance;
        }
        else 
        {
            Console.WriteLine("Initial balance cannot be negative. Setting balance to 0.");
            Balance = 0;
        }
    }

    //Controlled deposit
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    //Controlled withdrawal
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New balance: {Balance}");
        }
    }


}
