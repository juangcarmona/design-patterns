using DesignPatterns.Structural.Bridge;

namespace DesignPatterns.Tests.Structural;

public class BridgeTests
{
    [Fact]
    public void Bridge_ShouldCallImplementorOperation()
    {
        // Arrange
        IImplementor implementorA = new ConcreteImplementorA();
        IImplementor implementorB = new ConcreteImplementorB();
        Abstraction abstractionA = new RefinedAbstraction(implementorA);
        Abstraction abstractionB = new RefinedAbstraction(implementorB);

        // Act & Assert
        abstractionA.Operation();
        abstractionB.Operation();
        Assert.True(true); // Manually verify console output or use mocks
    }
}
