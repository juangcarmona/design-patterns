
# Visitor interface
class Visitor:
    def visit_concrete_element_a(self, element):
        pass

    def visit_concrete_element_b(self, element):
        pass

# Concrete Visitor
class ConcreteVisitor(Visitor):
    def visit_concrete_element_a(self, element):
        print("ConcreteVisitor: Visiting ConcreteElementA")

    def visit_concrete_element_b(self, element):
        print("ConcreteVisitor: Visiting ConcreteElementB")

# Element interface
class Element:
    def accept(self, visitor):
        pass

# Concrete Element A
class ConcreteElementA(Element):
    def accept(self, visitor):
        visitor.visit_concrete_element_a(self)

# Concrete Element B
class ConcreteElementB(Element):
    def accept(self, visitor):
        visitor.visit_concrete_element_b(self)

if __name__ == "__main__":
    elements = [ConcreteElementA(), ConcreteElementB()]
    visitor = ConcreteVisitor()

    for element in elements:
        element.accept(visitor)
