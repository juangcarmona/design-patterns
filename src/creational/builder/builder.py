
# Product class
class Product:
    def __init__(self):
        self._part_a = None
        self._part_b = None

    def set_part_a(self, part_a):
        self._part_a = part_a

    def set_part_b(self, part_b):
        self._part_b = part_b

    def show(self):
        print(f"Product built with PartA: {self._part_a}, PartB: {self._part_b}")

# Builder interface
class Builder:
    def build_part_a(self):
        pass

    def build_part_b(self):
        pass

    def get_result(self):
        pass

# Concrete Builder
class ConcreteBuilder(Builder):
    def __init__(self):
        self._product = Product()

    def build_part_a(self):
        self._product.set_part_a("PartA1")

    def build_part_b(self):
        self._product.set_part_b("PartB1")

    def get_result(self):
        return self._product

# Director class
class Director:
    def construct(self, builder):
        builder.build_part_a()
        builder.build_part_b()

if __name__ == "__main__":
    director = Director()
    builder = ConcreteBuilder()

    director.construct(builder)
    product = builder.get_result()
    product.show()
