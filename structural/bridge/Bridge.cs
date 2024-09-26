
using System;

// Implementor interface
public interface IImplementor
{
    void OperationImpl();
}

// Concrete Implementor A
public class ConcreteImplementorA : IImplementor
{
    public void OperationImpl()
    {
        Console.WriteLine("ConcreteImplementorA Operation");
    }
}

// Concrete Implementor B
public class ConcreteImplementorB : IImplementor
{
    public void OperationImpl()
    {
        Console.WriteLine("ConcreteImplementorB Operation");
    }
}

// Abstraction class
public class Abstraction
{
    protected IImplementor _implementor;

    public Abstraction(IImplementor implementor)
    {
        _implementor = implementor;
    }

    public virtual void Operation()
    {
        _implementor.OperationImpl();
    }
}

// Refined Abstraction class
public class RefinedAbstraction : Abstraction
{
    public RefinedAbstraction(IImplementor implementor) : base(implementor) { }

    public override void Operation()
    {
        Console.WriteLine("RefinedAbstraction Operation");
        base.Operation();
    }
}

// Client code
class Program
{
    static void Main()
    {
        Abstraction abstraction;

        abstraction = new RefinedAbstraction(new ConcreteImplementorA());
        abstraction.Operation();

        abstraction = new RefinedAbstraction(new ConcreteImplementorB());
        abstraction.Operation();
    }
}
