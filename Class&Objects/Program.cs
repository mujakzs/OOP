// See https://aka.ms/new-console-template for more information

//A Class is a blueprint for creating objects. It defines properties and methods that the objects created from the class will have.
//An object is an instance of a class, which means it is a specific realization of the class with actual


public class Product
{
    //fields and Properties
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }

    //Constructor
    public Product(string name, string category, double price)
    {
        Name = name;
        Category = category;
        Price = price;
    }

    //Method
    public void DisplayInfo()
    {
        Console.WriteLine($"Product Name: {Name}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine($"Price: ${Price}");
    }

    //Method with parameters
    public void ApplyDiscount(double percentage)
    {
        Price -= Price * (percentage / 100); //Price = Price - (Price * (percentage / 100))

        Console.WriteLine($"Discounted price: {Price}");
    }

    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
        if (newPrice <= Price)
        {
            Console.WriteLine("Price must be higher than Discounted Price.");
        }
        Console.WriteLine($"Updated price: {Price}");
    }


}

class Program
{
    static void Main(string[] args)
    {
        //Creating an instance of the Product class
        Product product1 = new Product("Laptop", "Asus", 2500.00);
        Product product2 = new Product("Movile", "Realme", 10000);

        //Accessing properties and methods
        product1.DisplayInfo();

        product1.ApplyDiscount(10);

        product1.UpdatePrice(2200.00);


        product2.DisplayInfo();
    }
}

/*

CLASS(Blueprint)
        ┌─────────────────┐
        │ Car             │
        │ - Color         │
        │ - Start()       │
        └─────────────────┘
                 ↓ creates

 OBJECTS (Instances in memory)

   myCar1        myCar2        myCar3
 ┌────────┐   ┌────────┐   ┌────────┐
 │ Red    │   │ Blue   │   │ Black  │
 └────────┘   └────────┘   └────────┘

*/
