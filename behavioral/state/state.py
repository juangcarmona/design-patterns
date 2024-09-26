
# State interface
class State:
    def handle(self, context):
        pass

# Concrete State A
class ConcreteStateA(State):
    def handle(self, context):
        print("ConcreteStateA is handling the request.")
        context.set_state(ConcreteStateB())

# Concrete State B
class ConcreteStateB(State):
    def handle(self, context):
        print("ConcreteStateB is handling the request.")
        context.set_state(ConcreteStateA())

# Context class
class Context:
    def __init__(self, state):
        self._state = state

    def set_state(self, state):
        self._state = state
        print("State changed.")

    def request(self):
        self._state.handle(self)

if __name__ == "__main__":
    context = Context(ConcreteStateA())

    context.request()
    context.request()
    context.request()
