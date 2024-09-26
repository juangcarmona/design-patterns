
# Singleton class
class Singleton:
    _instance = None

    def __new__(cls):
        if cls._instance is None:
            cls._instance = super(Singleton, cls).__new__(cls)
        return cls._instance

    def do_something(self):
        print("Singleton instance is doing something.")

if __name__ == "__main__":
    instance1 = Singleton()
    instance1.do_something()

    instance2 = Singleton()
    print(instance1 is instance2)  # True
