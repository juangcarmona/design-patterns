
# Target class
class Target:
    def request(self):
        print("Target: Default behavior")

# Adaptee class
class Adaptee:
    def specific_request(self):
        print("Adaptee: Specific behavior")

# Adapter class
class Adapter(Target):
    def __init__(self, adaptee):
        self._adaptee = adaptee

    def request(self):
        print("Adapter: Adapting...")
        self._adaptee.specific_request()

if __name__ == "__main__":
    target = Adapter(Adaptee())
    target.request()
