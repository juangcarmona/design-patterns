namespace DesignPatterns.Behavioral.Interpreter;

// Context class
public class Context
{
    public string Data { get; set; }
}

// Abstract Expression class
public abstract class Expression
{
    public abstract void Interpret(Context context);
}

// Terminal Expression class
public class TerminalExpression : Expression
{
    private string _data;

    public TerminalExpression(string data)
    {
        _data = data;
    }

    public override void Interpret(Context context)
    {
        if (context.Data.Contains(_data))
        {
            Console.WriteLine("TerminalExpression: Interpreting '" + _data + "'");
        }
    }
}

// Non-Terminal Expression class
public class NonTerminalExpression : Expression
{
    private List<Expression> _expressions = new List<Expression>();

    public void AddExpression(Expression expression)
    {
        _expressions.Add(expression);
    }

    public override void Interpret(Context context)
    {
        foreach (var expression in _expressions)
        {
            expression.Interpret(context);
        }
    }
}

class Program
{
    static void Main()
    {
        Context context = new Context { Data = "Hello world" };

        TerminalExpression terminalExpression = new TerminalExpression("Hello");
        NonTerminalExpression nonTerminalExpression = new NonTerminalExpression();
        nonTerminalExpression.AddExpression(terminalExpression);

        nonTerminalExpression.Interpret(context);
    }
}
