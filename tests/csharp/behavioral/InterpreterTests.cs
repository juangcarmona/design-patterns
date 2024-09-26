using DesignPatterns.Behavioral.Interpreter;


namespace DesignPatterns.Tests.Behavioral;

public class InterpreterTests
{
    [Fact]
    public void TerminalExpression_ShouldInterpretCorrectly()
    {
        // Arrange
        var context = new Context { Data = "Hello world" };
        var terminalExpression = new TerminalExpression("Hello");

        // Act & Assert
        terminalExpression.Interpret(context);
    }

    [Fact]
    public void NonTerminalExpression_ShouldInterpretAllExpressions()
    {
        // Arrange
        var context = new Context { Data = "Hello world" };
        var terminalExpression1 = new TerminalExpression("Hello");
        var terminalExpression2 = new TerminalExpression("world");
        var nonTerminalExpression = new NonTerminalExpression();
        nonTerminalExpression.AddExpression(terminalExpression1);
        nonTerminalExpression.AddExpression(terminalExpression2);

        // Act & Assert
        nonTerminalExpression.Interpret(context);
    }
}
