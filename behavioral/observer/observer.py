
# Subject interface
class Subject:
    def attach(self, observer):
        pass

    def detach(self, observer):
        pass

    def notify(self):
        pass

# Concrete Subject
class ConcreteSubject(Subject):
    def __init__(self):
        self._observers = []
        self._state = None

    def get_state(self):
        return self._state

    def set_state(self, state):
        self._state = state
        self.notify()

    def attach(self, observer):
        self._observers.append(observer)

    def detach(self, observer):
        self._observers.remove(observer)

    def notify(self):
        for observer in self._observers:
            observer.update()

# Observer interface
class Observer:
    def update(self):
        pass

# Concrete Observer
class ConcreteObserver(Observer):
    def __init__(self, subject):
        self._subject = subject
        self._subject.attach(self)

    def update(self):
        print(f"Observer updated with state: {self._subject.get_state()}")

if __name__ == "__main__":
    subject = ConcreteSubject()

    observer1 = ConcreteObserver(subject)
    observer2 = ConcreteObserver(subject)

    subject.set_state("State1")
    subject.set_state("State2")
