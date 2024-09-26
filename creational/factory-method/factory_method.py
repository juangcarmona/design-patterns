
# Product interface
class Product:
    def use(self):
        pass

# Concrete Product
class ConcreteProduct(Product):
    def use(self):
        print("Using ConcreteProduct.")

# Creator abstract class
class Creator:
    def factory_method(self):
        pass

    def some_operation(self):
        product = self.factory_method()
        product.use()

# Concrete Creator
class ConcreteCreator(Creator):
    def factory_method(self):
        return ConcreteProduct()

if __name__ == "__main__":
    creator = ConcreteCreator()
    creator.some_operation()
