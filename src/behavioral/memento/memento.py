
# Memento class
class Memento:
    def __init__(self, state):
        self._state = state

    def get_state(self):
        return self._state

# Originator class
class Originator:
    def __init__(self):
        self._state = None

    def set_state(self, state):
        self._state = state
        print(f"Originator: Setting state to {state}")

    def create_memento(self):
        return Memento(self._state)

    def restore_memento(self, memento):
        self._state = memento.get_state()
        print(f"Originator: State restored to {self._state}")

# Caretaker class
class Caretaker:
    def __init__(self):
        self._mementos = []

    def add_memento(self, memento):
        self._mementos.append(memento)

    def get_memento(self, index):
        return self._mementos[index]

if __name__ == "__main__":
    originator = Originator()
    caretaker = Caretaker()

    originator.set_state("State1")
    caretaker.add_memento(originator.create_memento())

    originator.set_state("State2")
    caretaker.add_memento(originator.create_memento())

    originator.set_state("State3")
    print(f"Current state: {originator.create_memento().get_state()}")

    # Restore to previous states
    originator.restore_memento(caretaker.get_memento(0))
    originator.restore_memento(caretaker.get_memento(1))
