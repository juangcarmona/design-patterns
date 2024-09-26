using DesignPatterns.Behavioral.Iterator;


namespace DesignPatterns.Tests.Behavioral;
public class IteratorTests
{
    [Fact]
    public void Iterator_ShouldIterateOverItems()
    {
        // Arrange
        var aggregate = new ConcreteAggregate();
        aggregate.AddItem("Item 1");
        aggregate.AddItem("Item 2");
        aggregate.AddItem("Item 3");
        var iterator = aggregate.CreateIterator();

        // Act & Assert
        Assert.True(iterator.HasNext());
        Assert.Equal("Item 1", iterator.Next());
        Assert.Equal("Item 2", iterator.Next());
        Assert.Equal("Item 3", iterator.Next());
        Assert.False(iterator.HasNext());
    }
}
