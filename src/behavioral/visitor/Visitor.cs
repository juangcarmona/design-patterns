namespace DesignPatterns.Behavioral.Visitor;

// Visitor interface
public interface IVisitor
{
    void VisitConcreteElementA(ConcreteElementA element);
    void VisitConcreteElementB(ConcreteElementB element);
}

// Concrete Visitor
public class ConcreteVisitor : IVisitor
{
    public void VisitConcreteElementA(ConcreteElementA element)
    {
        Console.WriteLine("ConcreteVisitor: Visiting ConcreteElementA");
    }

    public void VisitConcreteElementB(ConcreteElementB element)
    {
        Console.WriteLine("ConcreteVisitor: Visiting ConcreteElementB");
    }
}

// Element interface
public interface IElement
{
    void Accept(IVisitor visitor);
}

// Concrete Element A
public class ConcreteElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteElementA(this);
    }
}

// Concrete Element B
public class ConcreteElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteElementB(this);
    }
}

// Client code
class Program
{
    static void Main()
    {
        List<IElement> elements = new List<IElement> {
            new ConcreteElementA(),
            new ConcreteElementB()
        };

        IVisitor visitor = new ConcreteVisitor();

        foreach (var element in elements)
        {
            element.Accept(visitor);
        }
    }
}
