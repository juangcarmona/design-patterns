using DesignPatterns.Behavioral.Command;
namespace DesignPatterns.Tests.Behavioral;
public class CommandTests
{
    [Fact]
    public void ConcreteCommand_ShouldCallReceiverAction()
    {
        // Arrange
        var receiver = new Receiver();
        var command = new ConcreteCommand(receiver);
        var invoker = new Invoker();
        invoker.SetCommand(command);

        // Act & Assert
        invoker.ExecuteCommand();
    }
}
