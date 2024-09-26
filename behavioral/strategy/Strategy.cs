
using System;

// Strategy interface
public interface IStrategy
{
    void Execute();
}

// Concrete Strategy A
public class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("ConcreteStrategyA is being executed.");
    }
}

// Concrete Strategy B
public class ConcreteStrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("ConcreteStrategyB is being executed.");
    }
}

// Context class
public class Context
{
    private IStrategy _strategy;

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute();
    }
}

class Program
{
    static void Main()
    {
        Context context = new Context();

        context.SetStrategy(new ConcreteStrategyA());
        context.ExecuteStrategy();

        context.SetStrategy(new ConcreteStrategyB());
        context.ExecuteStrategy();
    }
}
