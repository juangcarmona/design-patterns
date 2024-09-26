
using System;
using System.Collections.Generic;

// Memento class
public class Memento
{
    private string _state;

    public Memento(string state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }
}

// Originator class
public class Originator
{
    private string _state;

    public void SetState(string state)
    {
        _state = state;
        Console.WriteLine("Originator: Setting state to " + state);
    }

    public Memento CreateMemento()
    {
        return new Memento(_state);
    }

    public void RestoreMemento(Memento memento)
    {
        _state = memento.GetState();
        Console.WriteLine("Originator: State restored to " + _state);
    }
}

// Caretaker class
public class Caretaker
{
    private List<Memento> _mementos = new List<Memento>();

    public void AddMemento(Memento memento)
    {
        _mementos.Add(memento);
    }

    public Memento GetMemento(int index)
    {
        return _mementos[index];
    }
}

class Program
{
    static void Main()
    {
        Originator originator = new Originator();
        Caretaker caretaker = new Caretaker();

        originator.SetState("State1");
        caretaker.AddMemento(originator.CreateMemento());

        originator.SetState("State2");
        caretaker.AddMemento(originator.CreateMemento());

        originator.SetState("State3");
        Console.WriteLine("Current state: " + originator.CreateMemento().GetState());

        // Restore to previous states
        originator.RestoreMemento(caretaker.GetMemento(0));
        originator.RestoreMemento(caretaker.GetMemento(1));
    }
}
