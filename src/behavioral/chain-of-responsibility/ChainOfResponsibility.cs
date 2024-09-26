namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public abstract class Handler
{
    protected Handler nextHandler;

    public void SetNext(Handler nextHandler)
    {
        this.nextHandler = nextHandler;
    }

    public abstract void HandleRequest(string request);
}

public class ConcreteHandler1 : Handler
{
    public override void HandleRequest(string request)
    {
        if (request == "Request1")
        {
            Console.WriteLine("ConcreteHandler1 handled the request.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(request);
        }
    }
}

public class ConcreteHandler2 : Handler
{
    public override void HandleRequest(string request)
    {
        if (request == "Request2")
        {
            Console.WriteLine("ConcreteHandler2 handled the request.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(request);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Handler handler1 = new ConcreteHandler1();
        Handler handler2 = new ConcreteHandler2();

        handler1.SetNext(handler2);

        handler1.HandleRequest("Request1");
        handler1.HandleRequest("Request2");
        handler1.HandleRequest("UnknownRequest");
    }
}
