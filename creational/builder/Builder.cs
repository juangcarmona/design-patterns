
using System;

// Product class
public class Product
{
    private string _partA;
    private string _partB;

    public void SetPartA(string partA)
    {
        _partA = partA;
    }

    public void SetPartB(string partB)
    {
        _partB = partB;
    }

    public void Show()
    {
        Console.WriteLine($"Product built with PartA: {_partA}, PartB: {_partB}");
    }
}

// Builder interface
public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    Product GetResult();
}

// Concrete Builder
public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    public void BuildPartA()
    {
        _product.SetPartA("PartA1");
    }

    public void BuildPartB()
    {
        _product.SetPartB("PartB1");
    }

    public Product GetResult()
    {
        return _product;
    }
}

// Director class
public class Director
{
    public void Construct(IBuilder builder)
    {
        builder.BuildPartA();
        builder.BuildPartB();
    }
}

// Client code
class Program
{
    static void Main()
    {
        Director director = new Director();
        IBuilder builder = new ConcreteBuilder();

        director.Construct(builder);
        Product product = builder.GetResult();
        product.Show();
    }
}
