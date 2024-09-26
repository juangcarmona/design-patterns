using DesignPatterns.Creational.Singleton;

namespace DesignPatterns.Tests.Creational;

public class SingletonTests
{
    [Fact]
    public void Singleton_ShouldReturnSameInstance()
    {
        // Act
        var instance1 = Singleton.GetInstance();
        var instance2 = Singleton.GetInstance();

        // Assert
        Assert.Equal(instance1, instance2);
        Assert.True(ReferenceEquals(instance1, instance2)); // Ensure it's the same instance
    }
}
