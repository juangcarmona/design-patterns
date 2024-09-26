using DesignPatterns.Structural.Flyweight;

namespace DesignPatterns.Tests.Structural;

public class FlyweightTests
{
    [Fact]
    public void Flyweight_ShouldReuseInstances()
    {
        // Arrange
        FlyweightFactory factory = new FlyweightFactory();
        var flyweightA = factory.GetFlyweight("A");
        var flyweightB = factory.GetFlyweight("B");
        var flyweightA2 = factory.GetFlyweight("A");

        // Act
        flyweightA.Operation("First Call");
        flyweightB.Operation("Second Call");
        flyweightA2.Operation("Third Call");

        // Assert
        Assert.Same(flyweightA, flyweightA2);
    }
}
