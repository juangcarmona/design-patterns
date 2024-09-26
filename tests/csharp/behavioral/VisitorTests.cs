using DesignPatterns.Behavioral.Visitor;

namespace DesignPatterns.Tests.Behavioral;
public class VisitorTests
{
    [Fact]
    public void Visitor_ShouldVisitConcreteElements()
    {
        // Arrange
        var elements = new List<IElement>
        {
            new ConcreteElementA(),
            new ConcreteElementB()
        };
        var visitor = new ConcreteVisitor();

        // Act & Assert
        foreach (var element in elements)
        {
            // Each element should accept the visitor and the corresponding visit method should be called.
            element.Accept(visitor);
        }
    }
}
