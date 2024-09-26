namespace DesignPatterns.Structural.Flyweight;

// Flyweight interface
public interface IFlyweight
{
    void Operation(string extrinsicState);
}

// Concrete Flyweight
public class ConcreteFlyweight : IFlyweight
{
    private string _intrinsicState;

    public ConcreteFlyweight(string intrinsicState)
    {
        _intrinsicState = intrinsicState;
    }

    public void Operation(string extrinsicState)
    {
        Console.WriteLine($"ConcreteFlyweight: Intrinsic State = {_intrinsicState}, Extrinsic State = {extrinsicState}");
    }
}

// Flyweight Factory
public class FlyweightFactory
{
    private Dictionary<string, IFlyweight> _flyweights = new Dictionary<string, IFlyweight>();

    public IFlyweight GetFlyweight(string key)
    {
        if (!_flyweights.ContainsKey(key))
        {
            _flyweights[key] = new ConcreteFlyweight(key);
        }

        return _flyweights[key];
    }
}

// Client code
class Program
{
    static void Main()
    {
        FlyweightFactory factory = new FlyweightFactory();

        var flyweight1 = factory.GetFlyweight("A");
        var flyweight2 = factory.GetFlyweight("B");
        var flyweight3 = factory.GetFlyweight("A");

        flyweight1.Operation("First Call");
        flyweight2.Operation("Second Call");
        flyweight3.Operation("Third Call");

        Console.WriteLine(object.ReferenceEquals(flyweight1, flyweight3)); // True
    }
}
