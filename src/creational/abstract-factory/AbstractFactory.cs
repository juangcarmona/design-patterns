
using System;

// Abstract Factory interface
public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}

// Concrete Factory 1
public class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}

// Concrete Factory 2
public class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}

// Abstract Product A
public interface IAbstractProductA
{
    void UseProductA();
}

// Concrete Product A1
public class ConcreteProductA1 : IAbstractProductA
{
    public void UseProductA()
    {
        Console.WriteLine("Using ConcreteProductA1");
    }
}

// Concrete Product A2
public class ConcreteProductA2 : IAbstractProductA
{
    public void UseProductA()
    {
        Console.WriteLine("Using ConcreteProductA2");
    }
}

// Abstract Product B
public interface IAbstractProductB
{
    void UseProductB();
}

// Concrete Product B1
public class ConcreteProductB1 : IAbstractProductB
{
    public void UseProductB()
    {
        Console.WriteLine("Using ConcreteProductB1");
    }
}

// Concrete Product B2
public class ConcreteProductB2 : IAbstractProductB
{
    public void UseProductB()
    {
        Console.WriteLine("Using ConcreteProductB2");
    }
}

// Client code
class Client
{
    private IAbstractProductA _productA;
    private IAbstractProductB _productB;

    public Client(IAbstractFactory factory)
    {
        _productA = factory.CreateProductA();
        _productB = factory.CreateProductB();
    }

    public void UseProducts()
    {
        _productA.UseProductA();
        _productB.UseProductB();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Client: Testing with ConcreteFactory1");
        Client client1 = new Client(new ConcreteFactory1());
        client1.UseProducts();

        Console.WriteLine("Client: Testing with ConcreteFactory2");
        Client client2 = new Client(new ConcreteFactory2());
        client2.UseProducts();
    }
}
