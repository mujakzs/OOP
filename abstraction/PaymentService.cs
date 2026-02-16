/* 
 
EXAMPLE 2.

*/


/*

class Program
{
    static void Main()
    {
        Console.Write("Enter amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nChoose Paymenet method");
        Console.WriteLine("1 - Gcash");
        Console.WriteLine("2 - Paymaya");

        Console.Write("\nEnter choice: ");
        string choice = Console.ReadLine();

        //Abstraction - Hides Complexity , Shows Essential Features
        IPaymentService paymentService;

        switch (choice)
        {
            case "1":
                paymentService = new GcashPayment();
                break;
            case "2":
                paymentService = new PaymayaPayment();
                break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to Gcash.");
                paymentService = new GcashPayment();
                break;
        }

        paymentService.Pay(amount);
        Console.WriteLine("Payment processed successfully.");

    }
}

// =============================
// INTERFACE (Abstraction Layer)
// =============================

public interface IPaymentService
{
    public void Pay(double amount);
}


// =============================
// ABSTRACT CLASS (shared logic)
// =============================


public abstract class PaymentServiceBase : IPaymentService
{
    public abstract void Pay(double amount);

    protected void PrintReceipt(double amount)
    {
        Console.WriteLine($"Receipt printed: ₱{amount}");
    }
}


// =============================
// CONCRETE IMPLEMENTATIONS
// =============================

public class GcashPayment : PaymentServiceBase
{
    public override void Pay(double amount)
    {
        Console.WriteLine($"Processing Gcash payment of ₱{amount}");
        PrintReceipt(amount);
    }
}

public class PaymayaPayment : PaymentServiceBase
{
    public override void Pay(double amount)
    {
        Console.WriteLine($"Processing Paymaya payment of ₱{amount}");
        PrintReceipt(amount);
    }
}

     */


/*
        Why use BOTH interface + abstract class?

        Answer:

            Interface defines the contract.
            Abstract class shares reusable code.

        Rule:

            Interface → behavior contract

            Abstract → shared implementation
*/