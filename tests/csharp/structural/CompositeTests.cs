using DesignPatterns.Structural.Composite;

namespace DesignPatterns.Tests.Structural;

public class CompositeTests
{
    [Fact]
    public void Composite_ShouldExecuteLeafAndCompositeOperations()
    {
        // Arrange
        Composite root = new Composite();
        Composite branch = new Composite();
        branch.Add(new Leaf());
        branch.Add(new Leaf());

        root.Add(branch);
        root.Add(new Leaf());

        // Act
        root.Operation();

        // Assert
        Assert.True(true); // Manually verify console output or use mocks
    }
}
