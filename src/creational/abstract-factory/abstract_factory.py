
# Abstract Factory interface
class AbstractFactory:
    def create_product_a(self):
        pass

    def create_product_b(self):
        pass

# Concrete Factory 1
class ConcreteFactory1(AbstractFactory):
    def create_product_a(self):
        return ConcreteProductA1()

    def create_product_b(self):
        return ConcreteProductB1()

# Concrete Factory 2
class ConcreteFactory2(AbstractFactory):
    def create_product_a(self):
        return ConcreteProductA2()

    def create_product_b(self):
        return ConcreteProductB2()

# Abstract Product A
class AbstractProductA:
    def use_product_a(self):
        pass

# Concrete Product A1
class ConcreteProductA1(AbstractProductA):
    def use_product_a(self):
        print("Using ConcreteProductA1")

# Concrete Product A2
class ConcreteProductA2(AbstractProductA):
    def use_product_a(self):
        print("Using ConcreteProductA2")

# Abstract Product B
class AbstractProductB:
    def use_product_b(self):
        pass

# Concrete Product B1
class ConcreteProductB1(AbstractProductB):
    def use_product_b(self):
        print("Using ConcreteProductB1")

# Concrete Product B2
class ConcreteProductB2(AbstractProductB):
    def use_product_b(self):
        print("Using ConcreteProductB2")

# Client code
class Client:
    def __init__(self, factory):
        self._product_a = factory.create_product_a()
        self._product_b = factory.create_product_b()

    def use_products(self):
        self._product_a.use_product_a()
        self._product_b.use_product_b()

if __name__ == "__main__":
    print("Client: Testing with ConcreteFactory1")
    client1 = Client(ConcreteFactory1())
    client1.use_products()

    print("Client: Testing with ConcreteFactory2")
    client2 = Client(ConcreteFactory2())
    client2.use_products()
