namespace DesignPatterns.Behavioral.Observer;

// Subject interface
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

// Concrete Subject
public class ConcreteSubject : ISubject
{
    private List<IObserver> _observers = new();
    private string _state;

    public void SetState(string state)
    {
        _state = state;
        Notify();  // Notifies observers when state changes
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);  // Adds observer to the list
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);  // Removes observer from the list
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();  // Notifies all observers
        }
    }

    public string GetState() => _state;  // Returns current state
}

// Observer interface
public interface IObserver
{
    void Update();  // Method to update the observer
}

// Concrete Observer
public class ConcreteObserver : IObserver
{
    private ConcreteSubject _subject;

    public ConcreteObserver(ConcreteSubject subject)
    {
        _subject = subject;
        _subject.Attach(this);  // Automatically attach to subject
    }

    public void Update()
    {
        Console.WriteLine("Observer updated with state: " + _subject.GetState());
    }
}

// Client code
class Program
{
    static void Main()
    {
        var subject = new ConcreteSubject();

        var observer1 = new ConcreteObserver(subject);
        var observer2 = new ConcreteObserver(subject);

        subject.SetState("State1");
        subject.SetState("State2");
    }
}
