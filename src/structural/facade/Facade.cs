
using System;

// Subsystem A
public class SubsystemA
{
    public void OperationA()
    {
        Console.WriteLine("SubsystemA: OperationA");
    }
}

// Subsystem B
public class SubsystemB
{
    public void OperationB()
    {
        Console.WriteLine("SubsystemB: OperationB");
    }
}

// Facade class
public class Facade
{
    private SubsystemA _subsystemA;
    private SubsystemB _subsystemB;

    public Facade(SubsystemA subsystemA, SubsystemB subsystemB)
    {
        _subsystemA = subsystemA;
        _subsystemB = subsystemB;
    }

    public void Operation()
    {
        Console.WriteLine("Facade: Operation");
        _subsystemA.OperationA();
        _subsystemB.OperationB();
    }
}

// Client code
class Program
{
    static void Main()
    {
        SubsystemA subsystemA = new SubsystemA();
        SubsystemB subsystemB = new SubsystemB();
        Facade facade = new Facade(subsystemA, subsystemB);
        facade.Operation();
    }
}
