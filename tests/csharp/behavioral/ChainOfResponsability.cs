using DesignPatterns.Behavioral.ChainOfResponsibility;

namespace DesignPatterns.Tests.Behavioral;

public class ChainOfResponsabilityTests
{
    [Fact]
    public void TestChainOfResponsibility()
    {
        // Arrange
        var handler1 = new ConcreteHandler1();
        var handler2 = new ConcreteHandler2();
        handler1.SetNext(handler2);

        // Act & Assert
        handler1.HandleRequest("Request1");
        handler1.HandleRequest("Request2");
        handler1.HandleRequest("UnknownRequest");
    }
}
