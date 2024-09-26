
# Context class
class Context:
    def __init__(self, data):
        self.data = data

# Abstract Expression class
class Expression:
    def interpret(self, context):
        pass

# Terminal Expression class
class TerminalExpression(Expression):
    def __init__(self, data):
        self._data = data

    def interpret(self, context):
        if self._data in context.data:
            print(f"TerminalExpression: Interpreting '{self._data}'")

# Non-Terminal Expression class
class NonTerminalExpression(Expression):
    def __init__(self):
        self._expressions = []

    def add_expression(self, expression):
        self._expressions.append(expression)

    def interpret(self, context):
        for expression in self._expressions:
            expression.interpret(context)

if __name__ == "__main__":
    context = Context("Hello world")

    terminal_expression = TerminalExpression("Hello")
    non_terminal_expression = NonTerminalExpression()
    non_terminal_expression.add_expression(terminal_expression)

    non_terminal_expression.interpret(context)
