using DesignPatterns.Behavioral.Memento;

namespace DesignPatterns.Tests.Behavioral;
public class MementoTests
{
    [Fact]
    public void Memento_ShouldRestorePreviousState()
    {
        // Arrange
        var originator = new Originator();
        var caretaker = new Caretaker();

        // Act
        originator.SetState("State1");
        caretaker.AddMemento(originator.CreateMemento());

        originator.SetState("State2");
        caretaker.AddMemento(originator.CreateMemento());

        originator.SetState("State3");

        // Assert
        originator.RestoreMemento(caretaker.GetMemento(0));
        Assert.Equal("State1", caretaker.GetMemento(0).GetState());

        originator.RestoreMemento(caretaker.GetMemento(1));
        Assert.Equal("State2", caretaker.GetMemento(1).GetState());
    }
}
