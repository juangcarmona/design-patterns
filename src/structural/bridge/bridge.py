
# Implementor interface
class Implementor:
    def operation_impl(self):
        pass

# Concrete Implementor A
class ConcreteImplementorA(Implementor):
    def operation_impl(self):
        print("ConcreteImplementorA Operation")

# Concrete Implementor B
class ConcreteImplementorB(Implementor):
    def operation_impl(self):
        print("ConcreteImplementorB Operation")

# Abstraction class
class Abstraction:
    def __init__(self, implementor):
        self._implementor = implementor

    def operation(self):
        self._implementor.operation_impl()

# Refined Abstraction class
class RefinedAbstraction(Abstraction):
    def operation(self):
        print("RefinedAbstraction Operation")
        super().operation()

if __name__ == "__main__":
    abstraction = RefinedAbstraction(ConcreteImplementorA())
    abstraction.operation()

    abstraction = RefinedAbstraction(ConcreteImplementorB())
    abstraction.operation()
