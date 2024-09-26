using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.Tests.Creational;

public class FactoryMethodTests
{
    [Fact]
    public void FactoryMethod_ShouldCreateProduct()
    {
        // Arrange
        Creator creator = new ConcreteCreator();

        // Act
        var product = creator.FactoryMethod();

        // Assert
        Assert.NotNull(product);
        product.Use();
    }
}
