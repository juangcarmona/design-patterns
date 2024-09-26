
# Flyweight interface
class Flyweight:
    def operation(self, extrinsic_state):
        pass

# Concrete Flyweight
class ConcreteFlyweight(Flyweight):
    def __init__(self, intrinsic_state):
        self._intrinsic_state = intrinsic_state

    def operation(self, extrinsic_state):
        print(f"ConcreteFlyweight: Intrinsic State = {self._intrinsic_state}, Extrinsic State = {extrinsic_state}")

# Flyweight Factory
class FlyweightFactory:
    def __init__(self):
        self._flyweights = {}

    def get_flyweight(self, key):
        if key not in self._flyweights:
            self._flyweights[key] = ConcreteFlyweight(key)
        return self._flyweights[key]

if __name__ == "__main__":
    factory = FlyweightFactory()

    flyweight1 = factory.get_flyweight("A")
    flyweight2 = factory.get_flyweight("B")
    flyweight3 = factory.get_flyweight("A")

    flyweight1.operation("First Call")
    flyweight2.operation("Second Call")
    flyweight3.operation("Third Call")

    print(flyweight1 is flyweight3)  # True
