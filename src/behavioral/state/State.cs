namespace DesignPatterns.Behavioral.State;

// State interface
public abstract class State
{
    public abstract void Handle(Context context);
}

// Concrete State A
public class ConcreteStateA : State
{
    public override void Handle(Context context)
    {
        Console.WriteLine("ConcreteStateA is handling the request.");
        context.SetState(new ConcreteStateB());
    }
}

// Concrete State B
public class ConcreteStateB : State
{
    public override void Handle(Context context)
    {
        Console.WriteLine("ConcreteStateB is handling the request.");
        context.SetState(new ConcreteStateA());
    }
}

// Context class
public class Context
{
    private State _state;

    public Context(State state)
    {
        _state = state;
    }

    public void SetState(State state)
    {
        _state = state;
        Console.WriteLine("State changed.");
    }

    public void Request()
    {
        _state.Handle(this);
    }
}

class Program
{
    static void Main()
    {
        Context context = new Context(new ConcreteStateA());

        context.Request();
        context.Request();
        context.Request();
    }
}
