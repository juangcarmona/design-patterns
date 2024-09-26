using DesignPatterns.Behavioral.Mediator;

namespace DesignPatterns.Tests.Behavioral;
public class MediatorTests
{
    [Fact]
    public void Mediator_ShouldCoordinateBetweenComponents()
    {
        // Arrange
        var component1 = new Component1();
        var component2 = new Component2();
        var mediator = new ConcreteMediator(component1, component2);

        // Act & Assert
        component1.DoAction1();  // Should trigger Component2
        component2.DoAction2();  // Should trigger Component1
    }
}
