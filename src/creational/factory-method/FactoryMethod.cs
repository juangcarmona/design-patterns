namespace DesignPatterns.Creational.FactoryMethod;

// Product interface
public interface IProduct
{
    void Use();
}

// Concrete Product
public class ConcreteProduct : IProduct
{
    public void Use()
    {
        Console.WriteLine("Using ConcreteProduct.");
    }
}

// Creator abstract class
public abstract class Creator
{
    public abstract IProduct FactoryMethod();

    public void SomeOperation()
    {
        var product = FactoryMethod();
        product.Use();
    }
}

// Concrete Creator
public class ConcreteCreator : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct();
    }
}

// Client code
class Program
{
    static void Main()
    {
        Creator creator = new ConcreteCreator();
        creator.SomeOperation();
    }
}
