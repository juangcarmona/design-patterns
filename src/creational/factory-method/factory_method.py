# Product interface
class IceCream:
    def serve(self):
        pass

# Concrete Product: Cone
class ConeIceCream(IceCream):
    def serve(self):
        print("Serving ice cream in a cone.")

# Concrete Product: Cup
class CupIceCream(IceCream):
    def serve(self):
        print("Serving ice cream in a cup.")

# Creator abstract class
class IceCreamCreator:
    def factory_method(self):
        pass

    def serve_ice_cream(self):
        ice_cream = self.factory_method()
        ice_cream.serve()

# Concrete Creator: Cone
class ConeIceCreamCreator(IceCreamCreator):
    def factory_method(self):
        return ConeIceCream()

# Concrete Creator: Cup
class CupIceCreamCreator(IceCreamCreator):
    def factory_method(self):
        return CupIceCream()

# Client code
if __name__ == "__main__":
    ice_cream_type = input("Choose your ice cream type (cone/cup): ").lower()

    if ice_cream_type == "cone":
        creator = ConeIceCreamCreator()
    elif ice_cream_type == "cup":
        creator = CupIceCreamCreator()
    else:
        raise ValueError("Invalid ice cream type.")

    creator.serve_ice_cream()
