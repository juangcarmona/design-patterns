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
        if (_realSubject == null)
        {
            _realSubject = new RealSubject();
        }
        Console.WriteLine("Proxy: Logging request before forwarding to RealSubject.");
        _realSubject.Request();
    }
}

// Client code
class Program
{
    static void Main()
    {
        ISubject proxy = new Proxy();
        proxy.Request();
    }
}
