/*
namespace Polymorphism;

//EXAMPLE 3.

public class Program
{
    static void Main(string[] args)
    {
        Human baby = new Baby();
        Human adult = new Adult();

        baby.Speak();
        adult.Speak();

        baby.Crawl(); // This will cause a compile-time error because the Crawl method is not defined in the Human class
        
    }
}

public class Human
{
    public virtual void Speak()
    {
        Console.WriteLine("Human speaks");
    }

    public virtual void Crawl()
    {
        Console.WriteLine("Human crawls");
    }


}

public class Baby : Human 
{
    public override void Speak()
    {
        Console.WriteLine("Baby cries");
    }

    public override void Crawl()
    {
        Console.WriteLine("Baby crawls");
    }
}

public class Adult : Human
{
    public override void Speak()
    {
        Console.WriteLine("Adult talks");
    }
}

*/
