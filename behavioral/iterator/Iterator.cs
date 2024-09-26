
using System;
using System.Collections.Generic;

// Iterator interface
public interface IIterator
{
    bool HasNext();
    object Next();
}

// Concrete Iterator
public class ConcreteIterator : IIterator
{
    private List<string> _collection;
    private int _position = 0;

    public ConcreteIterator(List<string> collection)
    {
        _collection = collection;
    }

    public bool HasNext()
    {
        return _position < _collection.Count;
    }

    public object Next()
    {
        return HasNext() ? _collection[_position++] : null;
    }
}

// Aggregate interface
public interface IAggregate
{
    IIterator CreateIterator();
}

// Concrete Aggregate
public class ConcreteAggregate : IAggregate
{
    private List<string> _collection = new List<string>();

    public void AddItem(string item)
    {
        _collection.Add(item);
    }

    public IIterator CreateIterator()
    {
        return new ConcreteIterator(_collection);
    }
}

class Program
{
    static void Main()
    {
        ConcreteAggregate aggregate = new ConcreteAggregate();
        aggregate.AddItem("Item 1");
        aggregate.AddItem("Item 2");
        aggregate.AddItem("Item 3");

        IIterator iterator = aggregate.CreateIterator();
        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}
