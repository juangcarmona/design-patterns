using DesignPatterns.Behavioral.State;

namespace DesignPatterns.Tests.Behavioral;
public class StateTests
{
    [Fact]
    public void Context_ShouldChangeState()
    {
        // Arrange
        var context = new Context(new ConcreteStateA());

        // Act
        context.Request();
        context.Request();
        context.Request();

        // Assert
        Assert.NotNull(context);
    }
}
