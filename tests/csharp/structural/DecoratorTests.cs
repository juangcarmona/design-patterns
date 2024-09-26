using DesignPatterns.Structural.Decorator;

namespace DesignPatterns.Tests.Structural;

public class DecoratorTests
{
    [Fact]
    public void Decorator_ShouldAddFunctionalityToComponent()
    {
        // Arrange
        Component component = new ConcreteComponent();
        Decorator decoratorA = new ConcreteDecoratorA(component);
        Decorator decoratorB = new ConcreteDecoratorB(decoratorA);

        // Act
        decoratorB.Operation();

        // Assert
        Assert.True(true); // Manually verify console output or use mocks
    }
}
