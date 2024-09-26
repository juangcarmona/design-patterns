
# Strategy interface
class Strategy:
    def execute(self):
        pass

# Concrete Strategy A
class ConcreteStrategyA(Strategy):
    def execute(self):
        print("ConcreteStrategyA is being executed.")

# Concrete Strategy B
class ConcreteStrategyB(Strategy):
    def execute(self):
        print("ConcreteStrategyB is being executed.")

# Context class
class Context:
    def __init__(self):
        self._strategy = None

    def set_strategy(self, strategy):
        self._strategy = strategy

    def execute_strategy(self):
        self._strategy.execute()

if __name__ == "__main__":
    context = Context()

    context.set_strategy(ConcreteStrategyA())
    context.execute_strategy()

    context.set_strategy(ConcreteStrategyB())
    context.execute_strategy()
