using DesignPatterns.Behavioral.Strategy;

namespace DesignPatterns.Tests.Behavioral;
public class StrategyTests
{
    [Fact]
    public void Context_ShouldUseConcreteStrategyA()
    {
        // Arrange
        var context = new Context();
        context.SetStrategy(new ConcreteStrategyA());

        // Act & Assert
        context.ExecuteStrategy();
    }

    [Fact]
    public void Context_ShouldUseConcreteStrategyB()
    {
        // Arrange
        var context = new Context();
        context.SetStrategy(new ConcreteStrategyB());

        // Act & Assert
        context.ExecuteStrategy();
    }
}
