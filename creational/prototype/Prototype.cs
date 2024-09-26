
using System;

// Prototype interface
public interface IPrototype
{
    IPrototype Clone();
}

// Concrete Prototype 1
public class ConcretePrototype1 : IPrototype
{
    public IPrototype Clone()
    {
        Console.WriteLine("Cloning ConcretePrototype1.");
        return (IPrototype)this.MemberwiseClone();
    }
}

// Concrete Prototype 2
public class ConcretePrototype2 : IPrototype
{
    public IPrototype Clone()
    {
        Console.WriteLine("Cloning ConcretePrototype2.");
        return (IPrototype)this.MemberwiseClone();
    }
}

// Client code
class Program
{
    static void Main()
    {
        IPrototype prototype1 = new ConcretePrototype1();
        IPrototype clone1 = prototype1.Clone();

        IPrototype prototype2 = new ConcretePrototype2();
        IPrototype clone2 = prototype2.Clone();
    }
}
