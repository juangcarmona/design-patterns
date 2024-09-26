```mermaid
classDiagram
    class AbstractExpression {
        +interpret(Context context)
    }

    class TerminalExpression {
        +interpret(Context context)
    }

    class NonTerminalExpression {
        +interpret(Context context)
    }

    class Context {
        -data: String
    }

    AbstractExpression <|-- TerminalExpression
    AbstractExpression <|-- NonTerminalExpression
    NonTerminalExpression --> AbstractExpression : expressions
```