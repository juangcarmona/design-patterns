
using System;
using System.Collections.Generic;

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
    private List<IObserver> _observers = new List<IObserver>();
    private string _state;

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
        Notify();
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}

// Observer interface
public interface IObserver
{
    void Update();
}

// Concrete Observer
public class ConcreteObserver : IObserver
{
    private ConcreteSubject _subject;

    public ConcreteObserver(ConcreteSubject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }

    public void Update()
    {
        Console.WriteLine("Observer updated with state: " + _subject.GetState());
    }
}

class Program
{
    static void Main()
    {
        ConcreteSubject subject = new ConcreteSubject();

        ConcreteObserver observer1 = new ConcreteObserver(subject);
        ConcreteObserver observer2 = new ConcreteObserver(subject);

        subject.SetState("State1");
        subject.SetState("State2");
    }
}
