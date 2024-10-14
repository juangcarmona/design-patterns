namespace DesignPatterns.Structural.Proxy;

// Subject interface
public interface ISubject
{
    void Request();
}

// Real Subject
public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling request.");
    }
}

// Proxy
public class Proxy : ISubject
{
    private RealSubject _realSubject;

    public void Request()
    {
        // Lazy initialization of RealSubject
        if (_realSubject == null)
        {
            _realSubject = new RealSubject();
        }
        
        Console.WriteLine("Proxy: Logging request before forwarding.");
        _realSubject.Request(); // Delegating to RealSubject
    }
}

// Client code
class Program
{
    static void Main()
    {
        // In a real-world application, consider using Dependency Injection (DI) to manage RealSubject.
        ISubject proxy = new Proxy();
        proxy.Request();
    }
}
