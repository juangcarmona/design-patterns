
using System;

// Target class
public class Target
{
    public virtual void Request()
    {
        Console.WriteLine("Target: Default behavior");
    }
}

// Adaptee class
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Adaptee: Specific behavior");
    }
}

// Adapter class
public class Adapter : Target
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public override void Request()
    {
        Console.WriteLine("Adapter: Adapting...");
        _adaptee.SpecificRequest();
    }
}

// Client code
class Program
{
    static void Main()
    {
        Target target = new Adapter(new Adaptee());
        target.Request();
    }
}
