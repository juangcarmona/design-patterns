using DesignPatterns.Creational.Prototype;

namespace DesignPatterns.Tests.Creational;

public class PrototypeTests
{
    [Fact]
    public void Prototype_ShouldCloneSuccessfully()
    {
        // Arrange
        IPrototype prototype1 = new ConcretePrototype1();
        IPrototype prototype2 = new ConcretePrototype2();

        // Act
        var clone1 = prototype1.Clone();
        var clone2 = prototype2.Clone();

        // Assert
        Assert.NotNull(clone1);
        Assert.NotNull(clone2);
    }
}
