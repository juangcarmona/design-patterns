namespace DesignPatterns.Structural.Decorator;

// Component interface
public abstract class Component
{
    public abstract void Operation();
}

// Concrete Component
public class ConcreteComponent : Component
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteComponent Operation");
    }
}

// Decorator class
public abstract class Decorator : Component
{
    protected Component _component;

    public Decorator(Component component)
    {
        _component = component;
    }

    public override void Operation()
    {
        if (_component != null)
        {
            _component.Operation();
        }
    }
}

// Concrete Decorator A
public class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(Component component) : base(component) { }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorA Operation");
    }
}

// Concrete Decorator B
public class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(Component component) : base(component) { }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorB Operation");
    }
}

// Client code
class Program
{
    static void Main()
    {
        Component component = new ConcreteComponent();
        Decorator decoratorA = new ConcreteDecoratorA(component);
        Decorator decoratorB = new ConcreteDecoratorB(decoratorA);

        decoratorB.Operation();
    }
}
