
# Component interface
class Component:
    def operation(self):
        pass

# Leaf class
class Leaf(Component):
    def operation(self):
        print("Leaf operation")

# Composite class
class Composite(Component):
    def __init__(self):
        self._children = []

    def add(self, component):
        self._children.append(component)

    def remove(self, component):
        self._children.remove(component)

    def operation(self):
        print("Composite operation")
        for child in self._children:
            child.operation()

if __name__ == "__main__":
    root = Composite()
    root.add(Leaf())

    branch = Composite()
    branch.add(Leaf())
    branch.add(Leaf())

    root.add(branch)
    root.operation()
