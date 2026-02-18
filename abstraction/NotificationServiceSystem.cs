namespace Abstraction;

class Program
{
    static void Main()
    {
        Console.Write("Please input message: ");
        string message = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine("Message cannot be empty.");
            return;
        }


        Console.WriteLine("\nChoose notification method:");
        Console.WriteLine("1 - Email");
        Console.WriteLine("2 - SMS");
        Console.WriteLine("3 - Push Notification");

        string choice = Console.ReadLine();

        INotificationService notif;

        switch (choice)
        {
            case "1":
                notif = new EmailNotification();
                break;
            case "2":
                notif = new SMSNotification();
                break;
            case "3":
                notif = new PushNotification();
                break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to Email Notification.");
                notif = new EmailNotification();
                break;
        }

        notif.SendNotification(message);
        Console.WriteLine("Notification sent successfully!");

    }
}

public interface INotificationService
{
    public void SendNotification(string message);
}

public abstract class NotificationServiceBase : INotificationService
{
    public abstract void SendNotification(string message);

    protected void LogNotification(string message)
    {
        Console.WriteLine($"Notification logged: {message}");
    }

    protected void SaveToDatabase(string message)
    {
        Console.WriteLine($"Notification saved to database: {message}");
    }

}

public class EmailNotification : NotificationServiceBase
{
    public override void SendNotification(string message)
    {
        // Simulate sending email
        Console.WriteLine($"Email sent: {message}");
        LogNotification(message);
        
    }

    public void CheckEmailStatus(string message)
    {
        Console.WriteLine($"Checking email status for: {message}");
    }
}

public class SMSNotification : NotificationServiceBase
{
    public override void SendNotification(string message)
    {
        // Simulate sending SMS
        Console.WriteLine($"SMS sent: {message}");
        LogNotification(message);
        SaveToDatabase(message);
    }
}

public class PushNotification : NotificationServiceBase
{
    public override void SendNotification(string message)
    {
        // Simulate sending push notification
        Console.WriteLine($"Push notification sent: {message}");
        LogNotification(message);
    }
}