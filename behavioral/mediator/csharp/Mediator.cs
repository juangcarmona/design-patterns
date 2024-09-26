
using System;

// Mediator interface
public interface IMediator
{
    void Notify(object sender, string eventCode);
}

// Concrete Mediator class
public class ConcreteMediator : IMediator
{
    private Component1 _component1;
    private Component2 _component2;

    public ConcreteMediator(Component1 component1, Component2 component2)
    {
        _component1 = component1;
        _component1.SetMediator(this);
        _component2 = component2;
        _component2.SetMediator(this);
    }

    public void Notify(object sender, string eventCode)
    {
        if (eventCode == "A")
        {
            Console.WriteLine("Mediator reacts to A and triggers following operations:");
            _component2.DoAction2();
        }
        else if (eventCode == "B")
        {
            Console.WriteLine("Mediator reacts to B and triggers following operations:");
            _component1.DoAction1();
        }
    }
}

// Component base class
public abstract class Component
{
    protected IMediator _mediator;

    public Component(IMediator mediator = null)
    {
        _mediator = mediator;
    }

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
}

// Component 1
public class Component1 : Component
{
    public void DoAction1()
    {
        Console.WriteLine("Component 1 does Action 1.");
        _mediator.Notify(this, "A");
    }
}

// Component 2
public class Component2 : Component
{
    public void DoAction2()
    {
        Console.WriteLine("Component 2 does Action 2.");
        _mediator.Notify(this, "B");
    }
}

class Program
{
    static void Main()
    {
        Component1 component1 = new Component1();
        Component2 component2 = new Component2();
        ConcreteMediator mediator = new ConcreteMediator(component1, component2);

        Console.WriteLine("Component 1 triggers action A.");
        component1.DoAction1();

        Console.WriteLine("Component 2 triggers action B.");
        component2.DoAction2();
    }
}
