
import copy

# Prototype interface
class Prototype:
    def clone(self):
        pass

# Concrete Prototype 1
class ConcretePrototype1(Prototype):
    def clone(self):
        print("Cloning ConcretePrototype1.")
        return copy.deepcopy(self)

# Concrete Prototype 2
class ConcretePrototype2(Prototype):
    def clone(self):
        print("Cloning ConcretePrototype2.")
        return copy.deepcopy(self)

if __name__ == "__main__":
    prototype1 = ConcretePrototype1()
    clone1 = prototype1.clone()

    prototype2 = ConcretePrototype2()
    clone2 = prototype2.clone()
