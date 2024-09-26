using DesignPatterns.Behavioral.TemplateMethod;

namespace DesignPatterns.Tests.Behavioral;
public class TemplateMethodTests
{
    [Fact]
    public void TemplateMethod_ShouldCallPrimitiveOperationsInOrder()
    {
        // Arrange
        AbstractClass instance = new ConcreteClass();
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        instance.TemplateMethod();

        // Assert
        var output = stringWriter.ToString();
        Assert.Contains("ConcreteClass.PrimitiveOperation1", output);
        Assert.Contains("ConcreteClass.PrimitiveOperation2", output);
    }
}
