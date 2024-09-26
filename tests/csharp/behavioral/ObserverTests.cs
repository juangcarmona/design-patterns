using DesignPatterns.Behavioral.Observer;

namespace DesignPatterns.Tests.Behavioral;
public class ObserverTests
{
    [Fact]
    public void Observer_ShouldUpdateWhenStateChanges()
    {
        // Arrange
        var subject = new ConcreteSubject();
        var observer1 = new ConcreteObserver(subject);
        var observer2 = new ConcreteObserver(subject);

        // Act
        subject.SetState("State1");

        // Assert
        Assert.Equal("State1", subject.GetState());

        // Act
        subject.SetState("State2");

        // Assert
        Assert.Equal("State2", subject.GetState());
    }
}
