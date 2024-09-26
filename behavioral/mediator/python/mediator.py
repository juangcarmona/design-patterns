
# Mediator interface
class Mediator:
    def notify(self, sender, event_code):
        pass

# Concrete Mediator class
class ConcreteMediator(Mediator):
    def __init__(self, component1, component2):
        self._component1 = component1
        self._component1.set_mediator(self)
        self._component2 = component2
        self._component2.set_mediator(self)

    def notify(self, sender, event_code):
        if event_code == "A":
            print("Mediator reacts to A and triggers following operations:")
            self._component2.do_action2()
        elif event_code == "B":
            print("Mediator reacts to B and triggers following operations:")
            self._component1.do_action1()

# Base Component class
class Component:
    def __init__(self, mediator=None):
        self._mediator = mediator

    def set_mediator(self, mediator):
        self._mediator = mediator

# Component 1
class Component1(Component):
    def do_action1(self):
        print("Component 1 does Action 1.")
        self._mediator.notify(self, "A")

# Component 2
class Component2(Component):
    def do_action2(self):
        print("Component 2 does Action 2.")
        self._mediator.notify(self, "B")

if __name__ == "__main__":
    component1 = Component1()
    component2 = Component2()
    mediator = ConcreteMediator(component1, component2)

    print("Component 1 triggers action A.")
    component1.do_action1()

    print("Component 2 triggers action B.")
    component2.do_action2()
