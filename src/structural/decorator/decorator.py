
# Component interface
class Component:
    def operation(self):
        pass

# Concrete Component
class ConcreteComponent(Component):
    def operation(self):
        print("ConcreteComponent Operation")

# Decorator class
class Decorator(Component):
    def __init__(self, component):
        self._component = component

    def operation(self):
        if self._component:
            self._component.operation()

# Concrete Decorator A
class ConcreteDecoratorA(Decorator):
    def operation(self):
        super().operation()
        print("ConcreteDecoratorA Operation")

# Concrete Decorator B
class ConcreteDecoratorB(Decorator):
    def operation(self):
        super().operation()
        print("ConcreteDecoratorB Operation")

if __name__ == "__main__":
    component = ConcreteComponent()
    decoratorA = ConcreteDecoratorA(component)
    decoratorB = ConcreteDecoratorB(decoratorA)

    decoratorB.operation()
