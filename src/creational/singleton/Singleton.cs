
using System;

// Singleton class
public class Singleton
{
    private static Singleton _instance;

    // Private constructor to prevent instantiation
    private Singleton() { }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }

    public void DoSomething()
    {
        Console.WriteLine("Singleton instance is doing something.");
    }
}

// Client code
class Program
{
    static void Main()
    {
        Singleton instance1 = Singleton.GetInstance();
        instance1.DoSomething();

        Singleton instance2 = Singleton.GetInstance();
        Console.WriteLine(object.ReferenceEquals(instance1, instance2)); // True
    }
}
