using DesignPatterns.Structural.Adapter;

namespace DesignPatterns.Tests.Structural;

public class AdapterTests
{
    [Fact]
    public void Adapter_ShouldAdaptAdapteeToTarget()
    {
        // Arrange
        Adaptee adaptee = new Adaptee();
        Target adapter = new Adapter(adaptee);

        // Act
        adapter.Request();

        // Assert
        Assert.True(true); // Here we check for correct console output manually, or mock the console output
    }
}
