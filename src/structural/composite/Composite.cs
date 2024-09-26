
using System;
using System.Collections.Generic;

// Component interface
public abstract class Component
{
    public abstract void Operation();
}

// Leaf class
public class Leaf : Component
{
    public override void Operation()
    {
        Console.WriteLine("Leaf operation");
    }
}

// Composite class
public class Composite : Component
{
    private List<Component> _children = new List<Component>();

    public void Add(Component component)
    {
        _children.Add(component);
    }

    public void Remove(Component component)
    {
        _children.Remove(component);
    }

    public override void Operation()
    {
        Console.WriteLine("Composite operation");
        foreach (var child in _children)
        {
            child.Operation();
        }
    }
}

// Client code
class Program
{
    static void Main()
    {
        Composite root = new Composite();
        root.Add(new Leaf());

        Composite branch = new Composite();
        branch.Add(new Leaf());
        branch.Add(new Leaf());

        root.Add(branch);
        root.Operation();
    }
}
