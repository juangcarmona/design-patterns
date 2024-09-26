using DesignPatterns.Creational.Builder;

namespace DesignPatterns.Tests.Creational;

public class BuilderTests
{
    [Fact]
    public void Builder_ShouldConstructProduct()
    {
        // Arrange
        var director = new Director();
        var builder = new ConcreteBuilder();

        // Act
        director.Construct(builder);
        var product = builder.GetResult();

        // Assert
        Assert.NotNull(product);
    }
}
