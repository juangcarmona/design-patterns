
# Abstract Class
class AbstractClass:
    def template_method(self):
        self.primitive_operation1()
        self.primitive_operation2()

    def primitive_operation1(self):
        pass

    def primitive_operation2(self):
        pass

# Concrete Class
class ConcreteClass(AbstractClass):
    def primitive_operation1(self):
        print("ConcreteClass.primitive_operation1")

    def primitive_operation2(self):
        print("ConcreteClass.primitive_operation2")

if __name__ == "__main__":
    instance = ConcreteClass()
    instance.template_method()
