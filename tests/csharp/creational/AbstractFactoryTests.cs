using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns.Tests.Creational;

public class AbstractFactoryTests
{
[Fact]
public void AbstractFactory_ShouldCreateProducts()
{
    // Arrange
    var factory1 = new ConcreteFactory1();
    var factory2 = new ConcreteFactory2();

    // Act
    var productA1 = factory1.CreateProductA();
    var productB1 = factory1.CreateProductB();

    var productA2 = factory2.CreateProductA();
    var productB2 = factory2.CreateProductB();

    // Assert
    Assert.NotNull(productA1);
    Assert.NotNull(productB1);
    Assert.NotNull(productA2);
    Assert.NotNull(productB2);
}
}