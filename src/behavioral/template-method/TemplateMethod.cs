namespace DesignPatterns.Behavioral.TemplateMethod;

// Abstract Class
public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        PrimitiveOperation1();
        PrimitiveOperation2();
    }

    public abstract void PrimitiveOperation1();
    public abstract void PrimitiveOperation2();
}

// Concrete Class
public class ConcreteClass : AbstractClass
{
    public override void PrimitiveOperation1()
    {
        Console.WriteLine("ConcreteClass.PrimitiveOperation1");
    }

    public override void PrimitiveOperation2()
    {
        Console.WriteLine("ConcreteClass.PrimitiveOperation2");
    }
}

class Program
{
    static void Main()
    {
        AbstractClass instance = new ConcreteClass();
        instance.TemplateMethod();
    }
}
