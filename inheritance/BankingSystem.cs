using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance;

public class BankingSystem
{
    public static void Main()
    {
        SavingsAccount savings = new SavingsAccount("SA123", 1000, 0.05);
        CheckingAccount checking = new CheckingAccount("CA456", 2000, 10);

        Console.WriteLine("=== Savings Account ===");
        savings.Deposit(500);
        savings.AddInterest();
        savings.AccountInfo();

        Console.WriteLine();

        Console.WriteLine("=== Checking Account ===");
        checking.Withdraw(300);
        checking.AccountInfo();
    }
}


public class BankAccount
{

    //fields and properties
    protected string AccountNumber { get; set; }
    protected double Balance { get; set; }


    //Constructor
    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    //methods - virtual allows derived classes to override this method with their own implementation
    public virtual void Deposit(double amount)
    {
        Balance += amount; 
        Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
    }


    //methods - virtual allows derived classes to override this method with their own implementation
    public virtual void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New balance: {Balance}");
        }
    }

    public void AccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
    }
}

public class SavingsAccount : BankAccount 
{
    private double InterestRate { get; set; }

    public SavingsAccount(string accountNumber, double balance, double interestRate) : base(accountNumber, balance) // Constructor Chaining using : base() to call the constructor of the base class (BankAccount) to initialize the account number and balance.
    {
        InterestRate = interestRate;
    }

    public void AddInterest()
    {
        double interest = Balance * InterestRate;
        Deposit(interest); // Reuse the Deposit method to add interest to the balance
        Console.WriteLine($"Added interest: {interest}. New balance: {Balance}");
    }
}

public class CheckingAccount : BankAccount
{
    private double TransactionFee { get; set; }

    public CheckingAccount(string accountNumber, double balance, double transactionFee) : base(accountNumber, balance)
    {
        TransactionFee = transactionFee;
    }

    public override void Withdraw(double amount)
    {
        double totalAmount = amount + TransactionFee;
        if (totalAmount > Balance)
        {
            Console.WriteLine("Insufficient funds including transaction fee.");
        }
        else
        {
            Balance -= totalAmount;
            Console.WriteLine($"Withdrew {amount} with a transaction fee of {TransactionFee}. New balance: {Balance}");
        }
    }
}